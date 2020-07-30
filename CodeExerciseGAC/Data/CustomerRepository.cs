using CodeExerciseGAC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeExerciseGAC.Data
{
    public class CustomerRepository : EfCoreRepository<Customers, AppDbContext>
    {
        public CustomerRepository(AppDbContext context) : base(context)
        {
        }
    }
}
