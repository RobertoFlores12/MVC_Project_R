﻿using ADS_Project.Utils;
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

        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                var item = grupoRepository.obtenerGrupo();
                return View(item);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        public IActionResult Form(int? idGrupo, Operaciones operaciones)
        {
            try
            {
                var grupo = new GrupoViewModel();

                if (idGrupo.HasValue)
                {
                    grupo = grupoRepository.obtenerGrupoPorID(idGrupo.Value);
                }

                //Indica el tipo de operacion que se esta realizando
                ViewData["Operaciones"] = operaciones;
                return View(grupo);

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
                if (grupoViewModel.idGrupo == 0) //En caso de insertar
                {

                    grupoRepository.agregarGrupo(grupoViewModel);
                }
                else //En caso de actualizar
                {
                    grupoRepository.actualizarGrupo(grupoViewModel.idGrupo,grupoViewModel);

                }

                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }
        }


        [HttpPost]
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
