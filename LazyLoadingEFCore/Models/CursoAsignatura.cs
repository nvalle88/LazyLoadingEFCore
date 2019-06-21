using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LazyLoadingEFCore.Models
{
    public class CursoAsignatura
    {
        [Key]
        public int IdCursoAsignatura { get; set; }
    }
}
