using CodeExerciseGAC.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeExerciseGAC.Models
{
    [Table("tblSalesOrder")]
    public class SalesOrder:IEntity
    {
        public int Id { get; set; }
        public string OrderNo { get; set; }
        public string CustRef { get; set; }

        public int CustomersId { get; set; }
        public virtual Customers Customers { get; set; }
    }
}
