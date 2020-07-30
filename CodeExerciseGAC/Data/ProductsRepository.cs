using CodeExerciseGAC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeExerciseGAC.Data
{
    public class ProductsRepository : EfCoreRepository<Products, AppDbContext>
    {
        public ProductsRepository(AppDbContext context) : base(context)
        {

        }
    }
}
