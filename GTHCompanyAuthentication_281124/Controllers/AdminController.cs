using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GTHCompanyAuthentication_281124.Controllers
{
   [Authorize]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult AddEmployee()//create employee
        {
            return View();
        }
        
        public ActionResult CreateAccount()
        {
            return View();
        }
    }
}