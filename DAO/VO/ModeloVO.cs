using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.VO
{
    public class ModeloVO
    {

        #region Informações que serão exibidas na GridView
        public string Marca { get; set; }
        public string Modelo { get; set; }
        #endregion
        
        
        //Propriedade que guardará o obj para ser editado (clique na linha)

        public Modelo ObjEditar { get; set; }

    }
}
