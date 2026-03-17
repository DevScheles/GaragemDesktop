using DAO.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DAO
{
    
    public class VeiculoDAO
    {
        db_garagemEntities objBd = new db_garagemEntities();

        public void AlterarVeiculo (Veiculo objVeiculo, List<int> lstAdicionais)
        {
            using (TransactionScope tran = new TransactionScope())
            {
                Veiculo objUpdate = objBd.Veiculo.Include("Adicional")
                    .FirstOrDefault(p => p.Id == objVeiculo.Id);

                objUpdate.Ano = objVeiculo.Ano;
                objUpdate.Km = objVeiculo.Km;
                objUpdate.Leilao = objVeiculo.Leilao;
                objUpdate.ModeloId = objVeiculo.ModeloId;
                objUpdate.Obs = objVeiculo.Obs;
                objUpdate.Placa = objVeiculo.Placa;
                objUpdate.Placa = objVeiculo.Placa;
                objUpdate.ValorCompra = objVeiculo.ValorCompra;
                objUpdate.ValorVenda = objVeiculo.ValorVenda;

                objUpdate.Adicional.Clear();

                if(lstAdicionais.Count > 0)
                {
                    foreach (var item in lstAdicionais)
                    {
                        Adicional objConfig = new Adicional();

                        objConfig.Id = item;
                        objUpdate.Id = objVeiculo.Id;


                        objBd.Adicional.Attach(objConfig);
                        objVeiculo.Adicional.Add(objConfig);
                    }

                    objBd.SaveChanges();
                    tran.Complete();
                }

            }
        }

        public void CadastrarVeiculo(Veiculo objVeiculo, List<int> lstIdsAdicionais)
        {
            if(lstIdsAdicionais.Count == 0)
            {
                objBd.Veiculo.Add(objVeiculo);
                objBd.SaveChanges();
            }
            else
            {
                using(TransactionScope tran = new TransactionScope())
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

                    objBd.SaveChanges();
                    tran.Complete();
                }
            }
        }

        public List<VeiculoVO> FiltrarVeiculo(int idGaragem, int modeloId)
        {
            //Lista de consulta
            List<Veiculo> lstConsulta = objBd.Veiculo
                                        .Include("Modelo.Marca")
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
                });

            }

            return lstRetorno;
        }
    }
}
