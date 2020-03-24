using Microsoft.AspNetCore.Mvc;

namespace ProjectName.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index() { return View(); }
  }
}