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
    public class SubjectControllerTests
    {
        [TestMethod]
        public void GetSubjects()
        {
            IList<Subject> genres = new List<Subject>()
            {
                new Subject() { Name = "Mathematics" },
                new Subject() { Name = "Physics" },
                new Subject() { Name = "Biology" },
                new Subject() { Name = "Literature" }
            };

            SubjectController controller = new SubjectController(genres);

            ActionResult result = controller.Index();

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(ViewResult));

            ViewResult viewResult = (ViewResult)result;

            Assert.IsInstanceOfType(viewResult.ViewData.Model, typeof(IList<Subject>));
            Assert.AreSame(genres, viewResult.ViewData.Model);
        }

        [TestMethod]
        public void GetSubjectForDetail()
        {
            IEnumerable<Subject> subjects = new List<Subject>()
            {
                new Subject() { Id = 1, Name = "Mathematics" },
                new Subject() { Id = 2, Name = "Physics" },
                new Subject() { Id = 3, Name = "Biology" },
                new Subject() { Id = 4, Name = "Literature" }
            };
            SubjectController controller = new SubjectController(subjects);
            ActionResult result = controller.Details(1);
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            ViewResult viewResult = (ViewResult)result;
            Assert.IsInstanceOfType(viewResult.ViewData.Model, typeof(Subject));
            Subject model = (Subject)viewResult.ViewData.Model;
            Assert.AreEqual(1, model.Id);
            Assert.AreEqual("Mathematics", model.Name);
        }
    }
}
