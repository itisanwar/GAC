using CodeExerciseGAC.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeExerciseGAC.Models
{
    [Table("tblSalesOrderDetails")]
    public class SalesOrderDetails:IEntity
    {
        public int Id { get; set; }
       
        public int SalesOrderId { get; set; }
        public virtual SalesOrder SalesOrder { get; set; }


        public int ProductsId { get; set; }
        public virtual Products Products  { get; set; }
        

        public double Qty { get; set; }
    }
}
