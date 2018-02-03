using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            if(DateTime.Today.DayOfWeek == DayOfWeek.Saturday)
            {   
                // Redirect is a method inherited from the Controller class
                return Redirect("/");
            }
            // Content is a method inherited from the Controller class
            return Content("Hello from the ComicBooksController!");
        }
    }
}