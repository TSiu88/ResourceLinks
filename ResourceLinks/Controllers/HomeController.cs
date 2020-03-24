using Microsoft.AspNetCore.Mvc;

namespace ResourceLinks.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index() { return View(); }
  }
}