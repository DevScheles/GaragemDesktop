using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.VO
{
    public class VendedorVO
    {
        //O que será exibido na grid.

        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Situacao { get; set; }
        public string Comissao { get; set; }

        // Propriedade para Alteração.

        public Vendedor objEditar { get; set; }

    }
}
