using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUD_Testing.Models;

namespace CRUD_Testing.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListPeople()
        {
            var people = new List<PersonModel>
            {
                new PersonModel()
                {
                    Id = 1,
                    FirstName = "Marco",
                    LastName = "Ruch",
                    Age = 15,
                    IsAlive = true,
                },
                new PersonModel()
                {
                    Id = 3,
                    FirstName = "Thierry",
                    LastName = "Mooser",
                    Age = 29,
                    IsAlive = true,
                },
                new PersonModel()
                {
                    Id = 1,
                    FirstName = "Fabienne",
                    LastName = "Schlüdele",
                    Age = 11,
                    IsAlive = false,
                }
            };




            return View(people);
        }
    }
}