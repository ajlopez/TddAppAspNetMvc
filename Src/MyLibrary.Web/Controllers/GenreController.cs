namespace MyLibrary.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using MyLibrary.Web.Models;

    public class GenreController : Controller
    {
        private IList<Genre> genres;

        public GenreController()
        {
        }

        public GenreController(IList<Genre> genres)
        {
            this.genres = genres;
        }

        public ActionResult Index()
        {
            return this.View(this.genres);
        }
    }
}
