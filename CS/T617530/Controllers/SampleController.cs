using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using T617530.Models;

namespace T617530.Controllers {
    public class SampleController : Controller {
        public SampleController(NorthwindContext context) {
            NorthwindContext = context;
        }
        protected NorthwindContext NorthwindContext { get; }
        public IActionResult GridView() {
            return View(NorthwindContext.Products);
        }
        public IActionResult GridViewPartial() {
            return PartialView(NorthwindContext.Products);
        }
        public IActionResult Details(int id)
        {
            return View("DetailView", id);
        }
    }
}