using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class AdicionalDAO
    {
        //1º Passo Criar banco de dados

        db_garagemEntities objBd = new db_garagemEntities();
        public List<Adicional> ConsultarAdicionais(int codLogado)
         => objBd.Adicional.Where(a => a.GaragemId == codLogado).OrderBy(a => a.Nome).ToList();


        int codigoRegistro = 0;
        string Informação = string.Empty;

        #region Métodos

        public void CadastrarAdicional(Adicional objAdicional)
        {



            //2º Passo: Add na table o obj do parâmetro
            //insert int to adicional (Adicional, Garagem) values (nome, idGaragem)
            objBd.Adicional.Add(objAdicional);

            //3º Salva no BD
            objBd.SaveChanges();
        }

        public void AlterarAdicional(Adicional objAdicional)
        {
            //Resgata o registro 
            Adicional objUpdate = objBd.Adicional.Where(a => a.Id == objAdicional.Id).FirstOrDefault();


            //Atualiza 
            objUpdate.Nome = objAdicional.Nome;

            //Salvar
            objBd.SaveChanges();
        }


        public void ExcluirAdicional(int idAdicional)
        {
            //Resgata o registro 
            Adicional objExcluir = objBd.Adicional.Where(a => a.Id == idAdicional).FirstOrDefault();
            objBd.Adicional.Remove(objExcluir);


            //Salvar as informações
            objBd.SaveChanges();
        }
        #endregion
    }
}





