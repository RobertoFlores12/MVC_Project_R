using ADS_Project.Utils;
using Microsoft.AspNetCore.Mvc;
using MVC_Project_R.Models;
using MVC_Project_R.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Project_R.Controllers
{
    public class GrupoController : Controller
    {

        private readonly IGrupoRepository grupoRepository;

        public GrupoController(IGrupoRepository gruposRepository)
        {
            this.grupoRepository = gruposRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form(int? idMateria, Operaciones operaciones)
        {
            try
            {
                var materia = new GrupoViewModel();

                if (idMateria.HasValue)
                {
                    materia = grupoRepository.obtenerGrupoPorID(idMateria.Value);
                }

                //Indica el tipo de operacion que se esta realizando
                ViewData["Operaciones"] = operaciones;
                return View(materia);

            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public IActionResult Form(GrupoViewModel grupoViewModel)
        {
            try
            {
                if (grupoViewModel.idMateria == 0) //En caso de insertar
                {

                    grupoRepository.agregarGrupo(grupoViewModel);
                }
                else //En caso de actualizar
                {
                    grupoRepository.actualizarGrupo(grupoViewModel.idMateria,grupoViewModel);

                }

                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }
        }


        [HttpGet]
        public IActionResult Delete(int idGrupo)
        {
            try
            {
                grupoRepository.eliminarGrupo(idGrupo);
            }
            catch (Exception)
            {

                throw;
            }

            return RedirectToAction("Index");
        }

    }
}
