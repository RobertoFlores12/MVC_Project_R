using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ADS_Project.Models;
using Microsoft.EntityFrameworkCore;
using MVC_Project_R.Models;

namespace MVC_Project_R.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<EstudianteViewModel> Estudiantes { get; set; }

        public DbSet<MateriaViewModel> Materias { get; set; }

        public DbSet<ProfesorViewModel> Profesores { get; set; }

        public DbSet<CarreraViewModel> Carreras { get; set; }

        public DbSet<GrupoViewModel> Grupos { get; set; }

    }
}
