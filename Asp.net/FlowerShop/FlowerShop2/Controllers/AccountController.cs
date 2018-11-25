using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlowerShop2.Controllers
{
    public class AccountController : Controller
    {
        

        [HttpPost]
        public ActionResult Register(Account account )
        {
            iAccountRepository.create(account);
            return View("MyAccount","Account");
        }
        [HttpGet]
        public ActionResult MyAccount()
        {
          return View("MyAccount");
        }
        [HttpPost]
        public ActionResult MyAccount(Account account)
        {
          Account acc = iAccountRepository.login(account.username, account.password); 
      if(acc == null)
      {
        ViewBag.error = "Account;s Invalid";
        return View("MyAccount");
      }
      Session["username"] = acc.username;
          return View("Welcome");
        }

        [HttpGet]
        public ActionResult Logout()
        {
          Session.Remove("username");
          return RedirectToAction("MyAccount","Account");
        }
  }
}