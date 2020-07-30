using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeExerciseGAC.Data;
using CodeExerciseGAC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeExerciseGAC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : BaseController<Customers, CustomerRepository>
    {
        public CustomerController(CustomerRepository repository) : base(repository)
        {
        }
    }
}
