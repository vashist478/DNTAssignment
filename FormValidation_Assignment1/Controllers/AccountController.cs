using FormValidation_Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace FormValidation_Assignment1.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult SignUp()
        {
            ViewBag.Country = GetCountry();
            UserViewModel mymodel = new UserViewModel();
            return View(mymodel);
        }

        [HttpPost]
        public IActionResult SignUp(UserViewModel model)
        {
            // ValidateFields(model);

            if (ModelState.IsValid)
            {
                return RedirectToAction("Message");
            }

            ViewBag.Country = GetCountry();
            UserViewModel mymodel = new UserViewModel();
            return View(mymodel);
        }

        public IActionResult Message()
        {
            return View();
        }


        /// <summary>
        /// Sk: Used to validate fields [Traditional Style]
        /// </summary>
        /// <param name="model"></param>
        [NonAction]
        public void ValidateFields(UserViewModel model)
        {
            /*traditional way  (Basic Approach)*/
            if (string.IsNullOrEmpty(model.Username))
            {
                ModelState.AddModelError("Username", "Please enter username");
            }
            if (string.IsNullOrEmpty(model.Name))
            {
                ModelState.AddModelError("Name", "Please enter name");
            }

            if (string.IsNullOrEmpty(model.Password))
            {

                ModelState.AddModelError("Password", "Please enter password");
            }

            if (string.IsNullOrEmpty(model.ConfirmPassword))
            {

                ModelState.AddModelError("ConfirmPassword", "Please enter ConfirmPassword");
            }

            if (!model.Terms)
            {

                ModelState.AddModelError("Terms", "Please check Terms and conditions");
            }

            if (ModelState.IsValid)
            {
                // return RedirectToAction("Message");
            }


            // return View();
        }

        /// <summary>
        /// Sk: Create Country record
        /// </summary>
        /// <returns></returns>
        public List<Country> GetCountry()
        {
            List<Country> countries = new List<Country>();
            countries.Add(new Country { CountryId = 1, CountryName = "India" });
            countries.Add(new Country { CountryId = 2, CountryName = "America" });
            countries.Add(new Country { CountryId = 3, CountryName = "New Zealand" });
            countries.Add(new Country { CountryId = 4, CountryName = "England" });
            countries.Add(new Country { CountryId = 5, CountryName = "Nepal" });
            return countries;
        }

        /// <summary>
        /// Sk: Bind State on selection of country
        /// </summary>
        /// <param name="CountryId"></param>
        /// <returns></returns>
        public IActionResult GetState(int CountryId)
        {
            List<State> states = new List<State>
            {
            new State { StateId = 1, CountryId = 1, StateName = "Bihar" },
            new State { StateId = 2, CountryId = 1, StateName = "Chandigarh" },
            new State { StateId = 3, CountryId = 1, StateName = "Bangalore" },
            new State { StateId = 4, CountryId = 2, StateName = "Alabama" },
            new State { StateId = 5, CountryId = 2, StateName = "Florida" },
            new State { StateId = 6, CountryId = 3, StateName = "Auckland" },
            new State { StateId = 7, CountryId = 3, StateName = "Nelson" },
            new State { StateId = 8, CountryId = 3, StateName = "West Coast" },
            new State { StateId = 9, CountryId = 3, StateName = "Taranaki" }
            };


            var jsonState = states.Where(item => item.CountryId == CountryId);
            return Json(states.Where(item => item.CountryId == CountryId));
        }
    }
}