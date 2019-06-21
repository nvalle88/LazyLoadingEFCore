using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LazyLoadingEFCore.Models
{
    public class AsignaturaProfesor
    {
        [Key]
        public int IdAsignaturaProfesor { get; set; }


        public int IdAsignatura { get; set; }
        public virtual Asignatura Asignatura { get; set; }

        public int IdProfesor { get; set; }
        public virtual Profesor Profesor { get; set; }
    }
}
