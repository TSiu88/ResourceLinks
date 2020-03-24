using Microsoft.AspNetCore.Mvc;
using ResourseLinks.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ResourseLinks.Controllers
{
  public class LinksController : Controller
  {
    private readonly ResourseLinksContext _db;

    public LinksController(ResourseLinksContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Links.ToList());
    }

    public ActionResult Create()
    {
      ViewBag.CategoryId = new SelectList(_db.Categories, "CategoryId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Link link, int CategoryId)
    {
      _db.Links.Add(link);
      if (CategoryId != 0)
      {
        _db.CategoryLink.Add(new CategoryLink() { CategoryId = CategoryId, LinkId = link.LinkId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisLink = _db.Links
        .Include(link => link.Categories)
        .ThenInclude(join => join.Category)
        .FirstOrDefault(link => link.LinkId == id);
      return View(thisLink);
    }

    public ActionResult Edit(int id)
    {
      var thisLink = _db.Links.FirstOrDefault(links => links.LinkId == id);
      ViewBag.CategoryId = new SelectList(_db.Categories, "CategoryId", "Name");
      return View(thisLink);
    }

    [HttpPost]
    public ActionResult Edit(Link link, int CategoryId)
    {
      if (CategoryId != 0)
      {
        _db.CategoryLink.Add(new CategoryLink() { CategoryId = CategoryId, LinkId = link.LinkId });
      }
      _db.Entry(link).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisLink = _db.Links.FirstOrDefault(links => links.LinkId == id);
      return View(thisLink);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisLink = _db.Links.FirstOrDefault(links => links.LinkId == id);
      _db.Links.Remove(thisLink);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddCategory(int id)
    {
      var thisLink = _db.Links.FirstOrDefault(links => links.LinkId == id);
      ViewBag.CategoryId = new SelectList(_db.Categories, "CategoryId", "Name");
      return View(thisLink);
    }

    [HttpPost]
    public ActionResult AddCategory(Link link, int CategoryId)
    {
      if (CategoryId != 0)
      {
      _db.CategoryLink.Add(new CategoryLink() { CategoryId = CategoryId, LinkId = link.LinkId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteCategory(int joinId)
    {
      var joinEntry = _db.CategoryLink.FirstOrDefault(entry => entry.CategoryLinkId == joinId);
      _db.CategoryLink.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}