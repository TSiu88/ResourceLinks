using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ResourseLinks.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ResourseLinks.Controllers
{
  public class TagsController : Controller
  {
    private readonly ResourseLinksContext _db;

    public TagsController(ResourseLinksContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Tags.ToList());
    }

    public ActionResult Create()
    {
      return View();
    }
    
    [HttpPost]
    public ActionResult Create(Tag tag)
    {
      _db.Tags.Add(tag);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisTag = _db.Tags
        .Include(tasg => tag.Links)
        .ThenInclude(join => join.Link)
        .FirstOrDefault(category => category.CategoryId == id);
      return View(thisTag);
    }

    public ActionResult Edit(int id)
    {
      var thisTag = _db.Tags.FirstOrDefault(tag => tag.TagId == id);
      return View(thisTag);
    }

    [HttpPost]
    public ActionResult Edit(Tag tag)
    {
      _db.Entry(tag).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisTag = _db.Tags.FirstOrDefault(tag => tag.TagId == id);
      return View(thisTag);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisTag = _db.Tags.FirstOrDefault(tag => tag.TagId == id);
      _db.Categories.Remove(thisTag);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}