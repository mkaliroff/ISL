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

        public ActionResult MyProfilePrimary()
        {
            return View();
        }

        public ActionResult MyProfileSecondary()
        {
            return View();
        }

        public ActionResult MyProfileSuccess()
        {
            return View();
        }

        public ActionResult MyProfileDanger()
        {
            return View();
        }

        public ActionResult MyProfileWarning()
        {
            return View();
        }

        public ActionResult MyProfileInfo()
        {
            return View();
        }

        public ActionResult MyProfileDark()
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

        [HttpPost]
        public ActionResult AddUser(User user)
        {
            UserDal dal = new UserDal();
            dal.Users.Add(user);//in Memorey adding
            dal.SaveChanges();//adding to DB from Memorey
            TempData["yes"] = "Welcome we are happy to have you with us!";
            return RedirectToAction("Register", "Home");
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("ShowHomePage", "Home");
        }

        [HttpPost]
        public ActionResult SignIn(User user)
        {
            UserDal dal = new UserDal();
            List<User> q = (from u in dal.Users where u.ID.Equals(user.ID) select u).ToList<User>();
           List<Admin> AdminQ = (from m in dal.Admins where m.ID.Equals(user.ID) select m).ToList<Admin>();

            if (AdminQ.Count() > 0 && AdminQ[0].ID.Equals(user.ID) && AdminQ[0].Password.Equals(user.Password))
            {
                Session["Admin"] = "Hello Admin";
                return RedirectToAction("ShowHomePage", "Home");
            }
            
            if (q.Count() > 0 && q[0].ID.Equals(user.ID) && q[0].Password.Equals(user.Password))
            {
                Session["user"] = "Hello " + q[0].FirstName;
                return RedirectToAction("ShowHomePage", "Home");
            }

            TempData["noSignIn"] = "You Dont Have An Acoount here Please Register First";

            return RedirectToAction("Login", "Home");
        }

    }
}

                              