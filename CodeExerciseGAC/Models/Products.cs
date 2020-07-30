using CodeExerciseGAC.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeExerciseGAC.Models
{
    [Table("tblProducts")]
    public class Products:IEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Dimension { get; set; }
    }
}
