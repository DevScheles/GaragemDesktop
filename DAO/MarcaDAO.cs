using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace DAO
{
    public class MarcaDAO
    {
        //1º Passo Criar banco de dados

        db_garagemEntities objBd = new db_garagemEntities();
        public List<Marca> ConsultarMarcas(int codLogado)
        {
            

            List<Marca> lstMarcas = objBd.Marca.Where(m => m.GaragemId == codLogado).ToList();
            //Select from marca where id = codLogado

            return lstMarcas;
        }
             



        public void CadastrarMarca(Marca objMarca)
        {



            //2º Passo: Add na table o obj do parâmetro
            //insert int to marca (Marca, Garagem) values (nome, idGaragem)
            objBd.Marca.Add(objMarca);

            //3º Salva no BD
            objBd.SaveChanges();


        }

        public void ExcluirMarca(int idMarca)
        {
            //Resgata o registro 
            Marca objExcluir = objBd.Marca.Where(m => m.Id == idMarca).FirstOrDefault();
            objBd.Marca.Remove(objExcluir);


            //Salvar as informações
            objBd.SaveChanges();
        }

        public void AlterarMarca(Marca objMarca)
        {
            //Resgata o registro 
            Marca objUpdate = objBd.Marca.Where(m => m.Id == objMarca.Id).FirstOrDefault();


            //Atualiza 
            objUpdate.Marca1 = objMarca.Marca1;

            //Salvar
            objBd.SaveChanges();
        }


    }
}
