namespace MyLibrary.Web.Tests.Controllers
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MyLibrary.Web.Controllers;
    using System.Web.Mvc;

    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void GetIndex()
        {
            HomeController controller = new HomeController();

            ActionResult result = controller.Index();

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(ViewResult));

            ViewResult viewResult = (ViewResult)result;
            Assert.IsNull(viewResult.Model);
        }
    }
}
