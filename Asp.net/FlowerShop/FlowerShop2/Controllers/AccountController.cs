using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlowerShop2.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult MyAccount()
        {
            return View("MyAccount");
        }

        public ActionResult Register()
        {
            return View("Register");
        }
    }
}