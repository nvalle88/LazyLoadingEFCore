using System;
using System.Collections.Generic;
using System.Text;
using LazyLoadingEFCore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LazyLoadingEFCore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        public virtual DbSet<Asignatura> Asignaturas { get; set; }
        public virtual DbSet<AsignaturaProfesor> AsignaturaProfesor { get; set; }
        public virtual DbSet<Curso> Cursos { get; set; }
        public virtual DbSet<CursoAsignatura> CursoAsignatura { get; set; }
        public virtual DbSet<CursoEstudiante> CursoEstudiante { get; set; }
        public virtual DbSet<Estudiante> Estudiante { get; set; }
        public virtual DbSet<Nivel> Nivel { get; set; }
        public virtual DbSet<Profesor> Profesor { get; set; }

    }
}
