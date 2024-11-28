using GTHCompanyAuthentication_281124.Models;
using GTHCompanyAuthentication_281124.Models.validation_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using System.Web.Security;

namespace GTHCompanyAuthentication_281124.Controllers
{
    
    public class GTHController : Controller
    {
        GTHCompanyEntities dbo = new GTHCompanyEntities();
        // GET: GTH
        [Authorize]
        public ActionResult showAllEmp()
        {
            return View();
        }
      
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(loginClass lgc)
        {
            if (ModelState.IsValid)
            {
                var lgdata = dbo.tblLogins.FirstOrDefault(x => x.userid == lgc.userid && x.password == lgc.password);
                if (lgdata != null) 
                {
                    FormsAuthentication.SetAuthCookie(lgc.userid,lgc.save);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid User ID or password!!");
                }
            }
            return View();
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("login", "GTH");
        }
    }
}