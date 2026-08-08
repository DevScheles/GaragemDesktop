using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class UsuarioDAO
    {
        db_garagemEntities objBd = new db_garagemEntities();

        public Acesso Logar (string login, string senha)
        {
            return objBd.Acesso.Where(a => a.Senha == senha
            && a.Login == login && a.Status == 1 && a.Tipo == 1).FirstOrDefault();
        }

    }
}
