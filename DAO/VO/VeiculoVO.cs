using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAO.VO
{
    public class VeiculoVO
    {

        public VeiculoVO()
        {

        }

        public VeiculoVO(int situacao)
        {
            switch (situacao)
            {
                case 0:
                    Situacao = "Inativo";
                    break;
                case 1:
                    Situacao = "Ativo";
                    break;
                case 2:
                    Situacao = "Vendido";
                    break;
            }

            
        }

        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Situacao { get; set; }

        //Carregar os campos para edição.
        public Veiculo objEdicao { get; set; }

      public string TextoSituacao(int situacao)
        {
            string texto = string.Empty;

            switch (situacao)
            {
                case 0:
                    texto = "Inativo";
                    break;
                case 1:
                    texto = "Ativo";
                    break;
                case 2:
                    texto = "Vendido";
                    break;
            }

            return texto;
        }

    }
}
