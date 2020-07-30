using CodeExerciseGAC.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeExerciseGAC.Models
{
    [Table("tblCustomers")]
    public class Customers:IEntity
    {
        [Key]

        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerLocation { get; set; }

    }
}
