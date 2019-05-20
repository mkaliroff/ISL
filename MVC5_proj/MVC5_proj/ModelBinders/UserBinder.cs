using MVC5_proj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5_proj.ModelBinders
{
    public class UserBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            //saving data from form doc
            HttpContextBase obj = controllerContext.HttpContext;
            string UserFirstName = obj.Request.Form["user.FirstName"];
            string UserLastName = obj.Request.Form["user.LastName"];
            string UserID = obj.Request.Form["user.ID"];
            string UserEmail = obj.Request.Form["user.Email"];
            string UserPassword = obj.Request.Form["user.Password"];

            User user = new User()
            {
                FirstName = UserFirstName,
                LastName = UserLastName,
                ID = UserID,
                Email = UserEmail,
                Password = UserPassword
            };

            return user;
        }
    }
}