namespace MyLibrary.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using MyLibrary.Web.Models;

    public class SubjectController : Controller
    {
        private IEnumerable<Subject> genres;

        public SubjectController()
        {
        }

        public SubjectController(IEnumerable<Subject> genres)
        {
            this.genres = genres;
        }

        public ActionResult Index()
        {
            return this.View(this.genres);
        }
    }
}
