using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ViewModelFun.Controllers
{
    public class ViewModelFunController : Controller
    {
        // Index
        [HttpGet]
        [Route ("")]
        public ViewResult Index ()
        {
            return View ();
        }

        // Numbers
        [HttpGet]
        [Route ("numbers")]
        public ViewResult Numbers ()
        {
            return View ("Numbers");
        }

        // Users
        [HttpGet]
        [Route ("users")]
        public ViewResult Users ()
        {
            return View ("Users");
        }

        // User
        [HttpGet]
        [Route ("user")]
        public ViewResult User ()
        {
            return View ("User");
        }

    }
}