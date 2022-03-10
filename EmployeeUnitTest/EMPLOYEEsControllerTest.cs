using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.Controllers;
using System.Web.Mvc;

namespace EmployeeUnitTest
{
    [TestClass]
    public class EMPLOYEEsControllerTest
    {
        [TestMethod]
        public void Index()
        {
            EMPLOYEEsController controller = new EMPLOYEEsController();
            ViewResult result = controller.Index() as ViewResult;
            ViewDataDictionary viewData = result.ViewData;
            Assert.AreEqual("Welcome", viewData["Message"]);

        }
    }
}
