using CodeExerciseGAC.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeExerciseGAC.Models
{
    [Table("tblManufacturer")]
    public class Manufacturer:IEntity 
    {
        [Key]
        public int Id { get; set; }
        public string ManufacName { get; set; }
        public string ManufacLocation { get; set; }
    }
}
