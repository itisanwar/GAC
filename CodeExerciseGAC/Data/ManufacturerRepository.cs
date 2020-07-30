using CodeExerciseGAC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeExerciseGAC.Data
{
    public class ManufacturerRepository : EfCoreRepository<Manufacturer, AppDbContext>
    {
        public ManufacturerRepository(AppDbContext context) : base(context)
        {

        }
    }
}