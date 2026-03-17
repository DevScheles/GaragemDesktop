using DAO.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{


    public class ModeloDAO
    {
        //1º Passo Criar banco de dados

        db_garagemEntities objBd = new db_garagemEntities();

    

    public void CadastrarModelo(Modelo objModelo)
        {
            
            objBd.Modelo.Add(objModelo);
            objBd.SaveChanges();
        }

        public void AlterarModelo(Modelo objModelo)
        {
            Modelo objUpdate = objBd.Modelo.Where(m => m.Id == objModelo.Id).FirstOrDefault();
            
                objUpdate.Modelo1 = objModelo.Modelo1;
                objUpdate.MarcaId = objModelo.MarcaId;
                

                objBd.SaveChanges();

        }

        public void ExcluirModelo(int idModelo)
        {
            Modelo objExcluir = objBd.Modelo.Where(m => m.Id == idModelo).FirstOrDefault();
            objBd.Modelo.Remove(objExcluir);
            objBd.SaveChanges();
        }

        public List<Modelo> FiltrarModelo(int idMarca, int garagemId)
            => objBd.Modelo.Where(m => m.MarcaId == idMarca && m.GaragemId == garagemId).ToList();
        public List<ModeloVO> ConsultarModelo(int codLogado)
        {
            //1º PASSO CONSULTAR NO BANCO DE DADOS

            List<Modelo> lstModelos = objBd.Modelo
                                      .AsNoTracking()
                                      .Include("Marca")
                                      .Where(m => m.GaragemId == codLogado).ToList();
            List<ModeloVO> lstRetorno = new List<ModeloVO>();

            foreach (var item in lstModelos)
            {
                ModeloVO vo = new ModeloVO();
                vo.Marca = item.Marca.Marca1;
                vo.Modelo = item.Modelo1;

                vo.ObjEditar = item;

                lstRetorno.Add(vo);
            }

            return lstRetorno;

        }
    }
}

