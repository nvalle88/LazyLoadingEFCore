using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LazyLoadingEFCore.Models
{
    public class Nivel
    {
        [Key]
        public int IdNivel { get; set; }

        public string Nombre { get; set; }
        
        public string Descripcion { get; set; }

        public virtual List<Curso> Cursos { get; set; }
    }
}
