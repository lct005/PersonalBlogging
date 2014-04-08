using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalBlogging.Domain.Entities;
using PersonalBlogging.Service;

namespace PersonalBlogging.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            var pbService = new PersonalPostService();
            pbService.AddBlog(new Post(){ Title = "test"});
            return View();
        }
	}
}