namespace DAO
{
    public class MarcaDAO
    {

        public void CadastrarMarca(Marca objMarca)
        {
            //1º Passo Criar banco de dados

            db_garagemEntities objBd = new db_garagemEntities();


            //2º Passo: Add na table o obj do parâmetro
            //insert int to marca (Marca, Garagem) values (nome, idGaragem)
            objBd.Marca.Add(objMarca);

            //3º Salva no BD
            objBd.SaveChanges();


        }

    }
}
