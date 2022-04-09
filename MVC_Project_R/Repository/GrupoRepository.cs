using System;
using MVC_Project_R.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Project_R.Repository
{
    public class GrupoRepository : IGrupoRepository
    {
        private readonly List<GrupoViewModel> lstGrupo;
        public GrupoRepository()
        {
            lstGrupo = new List<GrupoViewModel>
            {
                new GrupoViewModel{ idGrupo = 1, idMateria = 1,idCarrera=1,idProfesor = 1,
                Ciclo ="ciclo 01", year = "2022"
                }
            };
        }


        public int actualizarGrupo(int idGrupo, GrupoViewModel GrupoViewModel)
        {
            try
            {
                lstGrupo[lstGrupo.FindIndex(x => x.idGrupo == idGrupo)] = GrupoViewModel;
                return GrupoViewModel.idGrupo;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int agregarGrupo(GrupoViewModel GrupoViewModel)
        {
            try
            {
                if (lstGrupo.Count > 0)
                {
                    GrupoViewModel.idGrupo = lstGrupo.Last().idGrupo + 1;
                }
                else
                {
                   GrupoViewModel.idGrupo= 1;
                }
                lstGrupo.Add(GrupoViewModel);
                return GrupoViewModel.idGrupo;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool eliminarGrupo(int idGrupo)
        {
            try
            {
                lstGrupo.RemoveAt(lstGrupo.FindIndex(x => x.idGrupo == idGrupo));
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public GrupoViewModel obtenerGrupoPorID(int idGrupo)
        {
            try
            {
                var item = lstGrupo.Find(x => x.idGrupo == idGrupo);
                return item;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<GrupoViewModel> obtenerGrupo()
        {
            try
            {
                return lstGrupo;
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
