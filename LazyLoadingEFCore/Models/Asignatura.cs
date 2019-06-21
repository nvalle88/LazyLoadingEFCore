using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LazyLoadingEFCore.Models
{
    public class Asignatura
    {
        [Key]
        public int IdAsignatura { get; set; }

        public string Nombre { get; set; }

        public int CantidadHoras { get; set; }

        public virtual List<AsignaturaProfesor> AsignaturaProfesors { get; set; }
    }
}
