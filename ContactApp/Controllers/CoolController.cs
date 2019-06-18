using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ContactApp.Models;
using ContactApp.Data;

namespace ContactApp.Controllers
{
    [Route("contacts")]
    public class CoolController : Controller
    {
            
        public IActionResult Index()
        {
            return View();
        }

        [Route("get-all-contacts")]
        public IActionResult GetEveryone()
        {
            var getAllNumbers = new ContactViewModel
            {
                contactsList = ContactDatabase.contactsList
            };
            
            return View(getAllNumbers);
        }

        [Route("get-closest-contacts")]
        public IActionResult GetFriends()
        {
            var getAllNumbers = new ContactViewModel
            {
                contactsList = ContactDatabase.contactsList
            };

            return View(getAllNumbers);
          
        }
       [HttpGet]
        public IActionResult AddContact()
        {
            return View(new Contact());
        }

        [HttpPost]
        public IActionResult AddContact(Contact contactList)
        {
            ContactDatabase.contactsList.Add(contactList);

            return View(new Contact());
        }
    }
}