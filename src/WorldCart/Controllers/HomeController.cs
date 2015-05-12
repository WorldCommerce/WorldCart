using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WorldCart.Models;

namespace WorldCart.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View("Index", new Model1 { Title = "Model1", Summary = "Hello, world!" });
    }
  }
}
