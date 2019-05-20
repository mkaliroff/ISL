using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVC5_proj.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;



namespace MVC5_proj.Controllers.Tests
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void IndexViewTest()
        {
            //Arange
            HomeController controller = new HomeController();
            //Act
            ViewResult result = controller.Index() as ViewResult;
            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ShowHomePageViewTest()
        {
            //Arange
            HomeController controller = new HomeController();
            //Act
            ViewResult result = controller.ShowHomePage() as ViewResult;
            //Assert
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void ShowContactViewTest()
        {
            //Arange
            HomeController controller = new HomeController();
            //Act
            ViewResult result = controller.ShowContact() as ViewResult;
            //Assert
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void ShowAboutViewTest()
        {
            //Arange
            HomeController controller = new HomeController();
            //Act
            ViewResult result = controller.ShowAbout() as ViewResult;
            //Assert
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void FAQViewTest()
        {
            //Arange
            HomeController controller = new HomeController();
            //Act
            ViewResult result = controller.FAQ() as ViewResult;
            //Assert
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void Register()
        {
            //Arange
            HomeController controller = new HomeController();
            //Act
            ViewResult result = controller.Register() as ViewResult;
            //Assert
            Assert.IsNotNull(result);

        }
        [TestMethod]
        public void Login()
        {
            //Arange
            HomeController controller = new HomeController();
            //Act
            ViewResult result = controller.Login() as ViewResult;
            //Assert
            Assert.IsNotNull(result);

        }
        [TestMethod]
        public void MyProfile()
        {
            //Arange
            HomeController controller = new HomeController();
            //Act
            ViewResult result = controller.MyProfile() as ViewResult;
            //Assert
            Assert.IsNotNull(result);

        }
    }
}
