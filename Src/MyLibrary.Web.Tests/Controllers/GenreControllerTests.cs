namespace MyLibrary.Web.Tests.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Web.Mvc;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MyLibrary.Web.Controllers;
    using MyLibrary.Web.Models;

    [TestClass]
    public class GenreControllerTests
    {
        [TestMethod]
        public void GetGenres()
        {
            IList<Genre> genres = new List<Genre>()
            {
                new Genre() { Name = "Mathematics" },
                new Genre() { Name = "Physics" },
                new Genre() { Name = "Biology" },
                new Genre() { Name = "Literature" }
            };

            GenreController controller = new GenreController(genres);

            ActionResult result = controller.Index();

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(ViewResult));

            ViewResult viewResult = (ViewResult)result;

            Assert.IsInstanceOfType(viewResult.ViewData.Model, typeof(IList<Genre>));
            Assert.AreSame(genres, viewResult.ViewData.Model);
        }
    }
}
