using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LazyLoadingEFCore.Models
{
    public class CursoEstudiante
    {
        [Key]
        public int IdCursoEstudiante { get; set; }
    }
}
