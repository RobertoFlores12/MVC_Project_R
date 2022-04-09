using MVC_Project_R.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Project_R.Repository
{
     public interface IGrupoRepository
    {
        List<GrupoViewModel> obtenerGrupo();

        int agregarGrupo(GrupoViewModel GrupoViewModel);

        int actualizarGrupo(int idGrupo, GrupoViewModel GrupoViewModel);

        bool eliminarGrupo(int idGrupo);

        GrupoViewModel obtenerGrupoPorID(int idGrupo);
    }
}
