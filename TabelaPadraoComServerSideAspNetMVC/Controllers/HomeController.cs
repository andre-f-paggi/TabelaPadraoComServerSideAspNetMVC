using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TabelaPadraoComServerSideAspNetMVC.Context;
using TabelaPadraoComServerSideAspNetMVC.Models;

namespace TabelaPadraoComServerSideAspNetMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<EntityTest> model;
            using (var dbContext = new MyDbContext())
            {
                model = dbContext.EntitiesTest.ToList();
            }
            return View(model);
        }
    }
}