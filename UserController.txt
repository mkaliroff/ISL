using MVC5_proj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5_proj.ModelBinders;
using MVC5_proj.Dal;
using MVC5_proj.ModelView;
using System.Threading;

namespace MVC5_proj.Controllers
{
    public class UserController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        //saving data from DB to dal 
        [HttpPost]
        public ActionResult Send(Contact contact)
        {
            UserDal dal = new UserDal();
            dal.Contacts.Add(contact);//in Memorey adding
            dal.SaveChanges();//adding to DB from Memorey
            TempData["yes"] = "Thank you for contacting us – we will get back to you soon!";
            return RedirectToAction("ShowContact", "Home");
        }

        [HttpPost]
        public ActionResult Share(Language language)
        {
            UserDal dal = new UserDal();
            dal.languages.Add(language);//in Memorey adding
            dal.SaveChanges();//adding to DB from Memorey
            TempData["yes"] = "Word has been added Succsfulley";
            return RedirectToAction("ShowMyCollection", "Home");
        }

        [HttpPost]
        public ActionResult SendIT(IT service)
        {
            UserDal dal = new UserDal();
            dal.it.Add(service);//in Memorey adding
            dal.SaveChanges();//adding to DB from Memorey
            TempData["yes"] = "Thank you for contacting us – we will get back to you soon!";
            return RedirectToAction("ShowMyIT", "Home");
        }
    }
}