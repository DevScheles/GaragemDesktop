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
        
    }
}
