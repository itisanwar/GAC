using CodeExerciseGAC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeExerciseGAC.Data
{
    public class SalesOrderDetailRepository : EfCoreRepository<SalesOrderDetails, AppDbContext>
    {
        public SalesOrderDetailRepository(AppDbContext context) : base(context)
        {

        }
    }
}