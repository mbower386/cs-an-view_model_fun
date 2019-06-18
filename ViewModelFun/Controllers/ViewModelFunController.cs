using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class ViewModelFunController : Controller
    {
        // Index
        [HttpGet]
        [Route ("")]
        public IActionResult Index ()
        {
            Message message = new Message ();
            return View ("Index", message);
        }

        // Numbers
        [HttpGet]
        [Route ("numbers")]
        public IActionResult Numbers ()
        {
            Numbers numbers = new Numbers ();
            return View ("Numbers", numbers);
        }

        // Users
        [HttpGet]
        [Route ("users")]
        public IActionResult Users ()
        {
            Users users = new Users ();
            return View ("Users", users);
        }

        // User
        [HttpGet]
        [Route ("user")]
        public IActionResult DisplayUser ()
        {
            User user = new User ();
            return View ("User", user);
        }

    }
}