using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LazyLoadingEFCore.Models
{
    public class Curso
    {
        [Key]
        public int IdCurso { get; set; }

        public string Nombre { get; set; }

        public int IdNivel { get; set; }

        public virtual Nivel Nivel { get; set; }
    }
}
