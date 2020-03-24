using Microsoft.AspNetCore.Mvc;

namespace ResourseLinks.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index() { return View(); }
  }
}