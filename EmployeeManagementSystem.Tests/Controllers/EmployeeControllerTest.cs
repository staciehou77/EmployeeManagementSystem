using System;
using System.Text;
using System.Collections.Generic;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeManagementSystem;
using EmployeeManagementSystem.Controllers;

namespace EmployeeManagementSystem.Tests.Controllers
{
    /// <summary>
    /// EmployeeControllerTest 的摘要說明
    /// </summary>
    [TestClass]
    public class EmployeeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            
            EMPLOYEEsController controller = new EMPLOYEEsController();

            ViewResult result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);
        }
    }
}
