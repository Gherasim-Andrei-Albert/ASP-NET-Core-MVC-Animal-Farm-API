using FirstWebApi.Data;
using FirstWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApi.Controllers
{
    [Route("api/[controller]")]
    public class AnimalTypesController : Controller
    {
        private readonly MyDatabaseContext _context;

        public AnimalTypesController(MyDatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAnimalTypes()
        {
            return this.Ok(_context.AnimalTypes.ToList());
        }


        // TODO: POST (la fel ca la owners)

        // TODO: PUT (la fel ca la owners)

        // TODO: GET by id (la fel ca la owners)

        // TODO: DELETE (la fel ca la owners)
    }
}
