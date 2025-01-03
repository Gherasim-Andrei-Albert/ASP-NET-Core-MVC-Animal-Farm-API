using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstWebApi.Data;
using FirstWebApi.Models;

namespace FirstWebApi.Controllers
{
    [Route("api/[controller]")]
    public class AnimalsController : Controller
    {
        private readonly MyDatabaseContext _context;

        public AnimalsController(MyDatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAnimals()
        {
            return this.Ok(_context.Animals.ToList());
        }

        // TODO: POST (la fel ca la owners)
        // + Extra (Ce se intampla daca introduc un Animal dar nu am un AnimalType sau un Owner?); Cautati posibile cauze-raspunsuri si le discutam la curs


        // TODO: PUT (la fel ca la owners)


        // TODO: GET by id (la fel ca la owners)


        // TODO: DELETE (la fel ca la owners)

    }
}
