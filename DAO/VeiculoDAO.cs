using DAO.VO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DAO
{
    
    public class VeiculoDAO
    {
        db_garagemEntities objBd = new db_garagemEntities();

        public void AlterarVeiculo(Veiculo objVeiculo, List<int> lstIdsAdicionais, List<string> lstFotos)
        {
            using (db_garagemEntities db = new db_garagemEntities())
            {
                // 1. Busca o veículo incluindo a coleção de Adicionais
                Veiculo veiculoOriginal = db.Veiculo
                                            .Include("Adicional")
                                            .FirstOrDefault(v => v.Id == objVeiculo.Id);

                if (veiculoOriginal != null)
                {
                    // 2. Atualiza os dados cadastrais
                    veiculoOriginal.ModeloId = objVeiculo.ModeloId;
                    veiculoOriginal.Km = objVeiculo.Km;
                    veiculoOriginal.Obs = objVeiculo.Obs;
                    veiculoOriginal.Placa = objVeiculo.Placa;
                    veiculoOriginal.Situacao = objVeiculo.Situacao;
                    veiculoOriginal.Ano = objVeiculo.Ano;
                    veiculoOriginal.ValorCompra = objVeiculo.ValorCompra;
                    veiculoOriginal.ValorVenda = objVeiculo.ValorVenda;
                    veiculoOriginal.Leilao = objVeiculo.Leilao;

                    // 3. ATUALIZA OS ADICIONAIS (Evita duplicação de chave primária PK_VeiculoAdicional)
                    veiculoOriginal.Adicional.Clear(); // Limpa a relação no rastreador do EF

                    if (lstIdsAdicionais != null && lstIdsAdicionais.Count > 0)
                    {
                        foreach (int idAdicional in lstIdsAdicionais)
                        {
                            // Busca a entidade Adicional no contexto atual
                            var adicionalBanco = db.Adicional.FirstOrDefault(a => a.Id == idAdicional);
                            if (adicionalBanco != null)
                            {
                                veiculoOriginal.Adicional.Add(adicionalBanco);
                            }
                        }
                    }

                    // 4. ATUALIZA AS FOTOS (Remove as antigas e insere as novas)
                    var fotosExistentes = db.Foto.Where(f => f.VeiculoId == objVeiculo.Id).ToList();
                    if (fotosExistentes.Count > 0)
                    {
                        db.Foto.RemoveRange(fotosExistentes);
                    }

                    if (lstFotos != null && lstFotos.Count > 0)
                    {
                        foreach (string itemFoto in lstFotos)
                        {
                            string conteudoFoto = itemFoto;

                            // Se for um arquivo físico do computador, converte para Base64 antes de salvar
                            if (System.IO.File.Exists(itemFoto))
                            {
                                byte[] imageBytes = System.IO.File.ReadAllBytes(itemFoto);
                                conteudoFoto = Convert.ToBase64String(imageBytes);
                            }

                            Foto fotoBanco = new Foto
                            {
                                VeiculoId = objVeiculo.Id,
                                GaragemId = objVeiculo.GaragemId,
                                Foto1 = conteudoFoto
                            };

                            db.Foto.Add(fotoBanco);
                        }
                    }

                    // 5. Salva todas as alterações sem conflito de chave
                    db.SaveChanges();
                }
            }
        }

        public Veiculo CadastrarVeiculo(Veiculo objVeiculo, List<int> lstIdsAdicionais, List<string> lstFotos)
        {
            using (TransactionScope tran = new TransactionScope())
            {
                objBd.Veiculo.Add(objVeiculo);
                objBd.SaveChanges();


                foreach (var item in lstIdsAdicionais)
                {
                    Adicional objConfig = new Adicional();

                    objConfig.Id = item;
                    objBd.Adicional.Attach(objConfig);

                    objVeiculo.Adicional.Add(objConfig);
                }

                System.Diagnostics.Debug.WriteLine($"Fotos recebidas no DAO: {lstFotos.Count}");

                foreach (var foto in lstFotos)
                {
                    System.Diagnostics.Debug.WriteLine(foto);
                    Foto objFoto = new Foto();

                    objFoto.VeiculoId = objVeiculo.Id;
                    objFoto.GaragemId = objVeiculo.GaragemId;
                    objFoto.Foto1 = foto;

                    objBd.Foto.Add(objFoto);
                }


                objBd.SaveChanges();

                tran.Complete();

                return objVeiculo;
            }
        }

        public void ExcluirVeiculo(int idVeiculo)
        {
            using (var db = new db_garagemEntities()) // Substitua 'BancoContexto' pelo nome do seu DbContext (ex: GaragemEntities)
            {
                try
                {
                    // 1. Busca o veículo incluindo suas dependências/relacionamentos
                    var veiculo = db.Veiculo.Include("Adicional")
                                           .Include("Foto")
                                           .FirstOrDefault(v => v.Id == idVeiculo);

                    if (veiculo != null)
                    {
                        // 2. Limpa os adicionais vinculados ao veículo (Tabela N:N)
                        veiculo.Adicional.Clear();

                        // 3. Remove as fotos vinculadas ao veículo (Tabela 1:N)
                        if (veiculo.Foto != null && veiculo.Foto.Count > 0)
                        {
                            db.Foto.RemoveRange(veiculo.Foto);
                        }

                        // 4. Remove o veículo
                        db.Veiculo.Remove(veiculo);

                        // 5. Salva as alterações no banco de dados
                        db.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao excluir o veículo do banco de dados: " + ex.Message);
                }
            }
        }

        public List<VeiculoVO> FiltrarVeiculo(int idGaragem, int modeloId)
        {
            //Lista de consulta
            List<Veiculo> lstConsulta = objBd.Veiculo
                                        .Include("Modelo.Marca")
                                        .Include("Adicional")
                                        .Include("Foto")
                                        .Where(veiculo => veiculo.GaragemId == idGaragem
                                                          && veiculo.ModeloId == modeloId).ToList();

            //Lista de retorno
            List<VeiculoVO> lstRetorno = new List<VeiculoVO>();

            foreach (var item in lstConsulta)
            {
                lstRetorno.Add(new VeiculoVO(item.Situacao)
                {
                    Marca = item.Modelo.Marca.Marca1,
                    Modelo = item.Modelo.Modelo1,
                    objEdicao = item
                });

            }

            return lstRetorno;
        }

        public int ContarVeiculosAtivos(int garagemId)
        {
            return objBd.Veiculo.Count(v => v.GaragemId == garagemId && v.Situacao == 1);
        }

        public int ContarVeiculosVendidos(int garagemId)
        {
            return objBd.Veiculo.Count(v => v.GaragemId == garagemId && v.Situacao == 2);
        }

        public decimal ObterFaturamentoTotal(int garagemId)
{
    // Soma o campo de valor apenas dos veículos vendidos (Situacao == 2)
    // O cast (decimal?) evita erros caso não exista nenhuma venda cadastrada ainda
    return objBd.Veiculo
                .Where(v => v.GaragemId == garagemId && v.Situacao == 2)
                .Sum(v => (decimal?)v.ValorVenda) ?? 0;

        }

    }
}
