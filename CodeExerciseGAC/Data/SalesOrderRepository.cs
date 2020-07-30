using CodeExerciseGAC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeExerciseGAC.Data
{
    public class SalesOrderRepository : EfCoreRepository<SalesOrder, AppDbContext>
    {
        public SalesOrderRepository(AppDbContext context) : base(context)
        {

        }
    }
}
