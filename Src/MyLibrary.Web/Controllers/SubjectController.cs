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
        private IEnumerable<Subject> subjects;

        public SubjectController()
        {
        }

        public SubjectController(IEnumerable<Subject> subjects)
        {
            this.subjects = subjects;
        }

        public ActionResult Index()
        {
            return this.View(this.subjects);
        }

        public ActionResult Details(int id)
        {
            var model = this.subjects.Where(s => s.Id == id).FirstOrDefault();
            return View(model); 
        }
    }
}
