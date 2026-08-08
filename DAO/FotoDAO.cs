using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class FotoDAO
    {
        db_garagemEntities objBd = new db_garagemEntities();

        public void CadastrarFoto(Foto objFoto)
        {
            objBd.Foto.Add(objFoto);
            objBd.SaveChanges();
        }
    }
}
