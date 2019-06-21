using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LazyLoadingEFCore.Models
{
    public class Profesor
    {
        [Key]
        public int IdProfesor { get; set; }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public virtual List<AsignaturaProfesor> AsignaturaProfesors { get; set; }
    }
}
