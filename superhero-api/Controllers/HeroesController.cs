using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using superheroapi.Models;

namespace superheroapi.Controllers
{
    /// <summary>
    /// API endpoint for generating random Superhero or getting a Superhero name for a Persons name
    /// </summary>
    [Route("api/[controller]")]
    public class HeroesController : Controller
    {
        /// <summary>
        /// Returns a Person object with the Superhero name generated
        /// </summary>
        /// <param name="firstName">First Name of the Person object</param>
        /// <param name="lastName">Last Name of the Person object</param>
        /// <returns>New Person object</returns>
        /// <response code="200"></response>
        //[ProducesResponseTypeAttribute(typeof(Person), 200)]
        [HttpGet("{firstName}/{lastName}")]
        public Person Get(string firstName, string lastName)
        {
            var p = new Person() { FirstName = firstName, LastName = lastName };
            p.SetHeroName();

            return p;
        }
    }
}
