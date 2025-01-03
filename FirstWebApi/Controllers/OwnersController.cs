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
    public class OwnersController : Controller
    {
        private readonly MyDatabaseContext _context;

        public OwnersController(MyDatabaseContext context)
        {
            _context = context;
        }

        // api/owners
        [HttpGet]
        public IActionResult GetOwners()
        {
            var owners = _context.Owners.ToList();
            return this.Ok(owners);
        }

        // api/owners/1
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetOwner(int id)
        {
            var owners = _context.Owners.ToList();

            for (int i = 0; i < owners.Count; i++)
            {
                var owner = owners[i];

                if (owner.ID == id)
                {
                    // Daca gasesc owner
                    return this.Ok(owner);
                }

            }

            // Daca nu gasesc owner
            return this.NotFound();
        }

        // api/owners
        [HttpPost]
        public IActionResult CreateOwner([FromBody] Owners model)
        {
            // validez modelu primit ...
            if (ModelState.IsValid)
            {
                // ... tratez eventuale erori ce pot aparea la INSERT
                try
                {
                    this._context.Owners.Add(model);
                    this._context.SaveChanges();
                    return this.Ok(model);
                }
                catch (Exception)
                {
                    throw;
                }
                
            }

            // ... modelul nu este valid
            return this.BadRequest();
        }


        // api/owners/1
        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateOwner(int id, [FromBody] Owners model )
        {
            var owners = this._context.Owners.ToList();

            // TODO: Validare model primit
            // TODO: tratare eventuale erori la UPDATE

            foreach(var owner in owners)
            {
                if (owner.ID == id)
                {
                    owner.FirstName = model.FirstName;
                    owner.LastName = model.LastName;
                    owner.Age = model.Age;
                    this._context.Owners.Update(owner);
                    this._context.SaveChanges();
                    return this.Ok(owner);
                }
            }

            return this.NotFound();
        }

        // api/owners/1
        [HttpDelete]
        [Route("{id}")]

        public void DeleteOwner(int id)
        {
            // Luam toti owners
            // Cautam owner-ul nostru dupa id
            // Daca il gasim -> il stergem + tratare eventuale erori de server
            

            // Daca nu il gasesc -> intorc un raspuns cu status ??? code 
        }

    }
}
