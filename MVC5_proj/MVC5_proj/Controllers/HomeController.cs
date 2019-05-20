using MVC5_proj.Dal;
using MVC5_proj.Models;
using MVC5_proj.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5_proj.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowHomePage()
        {
            return View();
        }

        public ActionResult ShowContact()
        {
            return View();
        }

        public ActionResult ShowAbout()
        {

            return View();
        }


        public ActionResult ShowMyCollection()
        {
            return View();
        }


        public ActionResult ShowMyTestDB()
        {
            UserDal dal = new UserDal();
            List<IT> objIt = dal.it.ToList<IT>();
            List<Contact> objcon = dal.Contacts.ToList<Contact>();
            List<Language> objLan = dal.languages.ToList<Language>();
            UserViewModel uvm = new UserViewModel();

            uvm.its = objIt;
            uvm.languages = objLan;
            uvm.contacts = objcon;

            return View(uvm);
        }

        public ActionResult FAQ()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult MyProfile()
        {
                return View();

        }
    }
}