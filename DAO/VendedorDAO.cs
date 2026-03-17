using DAO.VO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;


namespace DAO
{
    public class VendedorDAO
    {

        //1º Passo Criar banco de dados

        db_garagemEntities objBd = new db_garagemEntities();

        public bool VerificarSeTemVenda(int idVendedor, int idGaragem)
            => !(objBd.Venda.Any(v => v.GaragemId == idGaragem && v.VendedorId == idVendedor) || objBd.Cliente.Any(c => c.VendedorId == idVendedor));

      


        public bool VerificarCpfDuplicado(int garagemId, string cpf)
            => objBd.Vendedor.Any(v => v.CPF == cpf && v.GaragemId == garagemId);
      

        public void CadastrarVendedor(Vendedor objVendedor)
        {

            objBd.Vendedor.Add(objVendedor);
            objBd.SaveChanges();
        }



        public List<VendedorVO> FiltrarVendedor(string nomeFiltro, int garagemId)
        {
            List<Vendedor> lstConsulta = objBd.Vendedor.Include("Acesso")
                            .Where(v => v.GaragemId == garagemId && v.Vendedor1.Contains(nomeFiltro)).
                            OrderBy(v => v.Vendedor1).ToList();

            List<VendedorVO> lstRetorno = new List<VendedorVO>();

            foreach (var item in lstConsulta)
            {
                VendedorVO vo = new VendedorVO();

                vo.Comissao = item.Comissao.ToString();
                vo.Nome = item.Vendedor1;
                vo.Telefone = item.Telefone;
                vo.Situacao = item.Acesso.FirstOrDefault()?.Status == 0 ? "Inativo" : "Ativo";


                vo.objEditar = item;

                lstRetorno.Add(vo);
            }

            return lstRetorno;


        }



        public void AlterarVendedor(Vendedor objVendedor, byte status)
        {
            using (TransactionScope tran = new TransactionScope())
            {
                Vendedor objUpdate = objBd.Vendedor
                                     .FirstOrDefault(v => v.Id == objVendedor.Id &&
                                                     v.GaragemId == objVendedor.GaragemId);

                objUpdate.Vendedor1 = objVendedor.Vendedor1;
                objUpdate.CPF = objVendedor.CPF;
                objUpdate.Email = objVendedor.Email;
                objUpdate.Telefone = objVendedor.Telefone;
                objUpdate.Endereco = objVendedor.Endereco;
                objUpdate.Comissao = objVendedor.Comissao;

                objBd.SaveChanges();

                Acesso objUpdateAcesso = objBd.Acesso.FirstOrDefault(a => a.VendedorId == objVendedor.Id);

                objUpdateAcesso.Status = status;
                objBd.SaveChanges();

                tran.Complete();
            }
        }

        public void ExcluirVendedor(int idVendedor, int idGaragem)
        {
            using (TransactionScope tran = new TransactionScope())
            {

                Acesso objExcluirAcesso = objBd.Acesso.FirstOrDefault(a => a.VendedorId == idVendedor);
                objBd.Acesso.Remove(objExcluirAcesso);



                Vendedor objExcluirVendedor = objBd.Vendedor
                                     .FirstOrDefault(v => v.Id == idVendedor &&
                                                     v.GaragemId == idGaragem);
                objBd.Vendedor.Remove(objExcluirVendedor);
                objBd.SaveChanges();

                tran.Complete();
            }


        }
    }
}
