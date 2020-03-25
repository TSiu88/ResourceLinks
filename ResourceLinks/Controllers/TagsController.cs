using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ResourceLinks.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ResourceLinks.Controllers
{
  public class TagsController : Controller
  {
    private readonly ResourceLinksContext _db;

    public TagsController(ResourceLinksContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Tags.ToList());
    }

    public ActionResult Create()
    {
      if(TempData["message"] != null)
      {
        ViewBag.Message = TempData["message"].ToString();
        TempData["message"] = null;
      }
      return View();
    }
    
    [HttpPost]
    public ActionResult Create(Tag tag)
    {
      List<Tag> thisTags = _db.Tags.ToList();
      int index = 0;
      foreach (Tag element in  thisTags)
      {
        if (element.Name != tag.Name && tag.Name != null)
        {
          index++;
        }
        if (index == thisTags.Count)
        {
          _db.Tags.Add(tag);
          _db.SaveChanges();
          return RedirectToAction("Index"); 
        }
      }
      if (tag.Name == null)
      {
        TempData ["message"] = "Tag Name is empty!";
      }
      else
      {
        TempData ["message"] = "Tag already exists!";
      }
      return Create();
    }

    public ActionResult Details(int id)
    {
      var thisTag = _db.Tags
        .Include(tag => tag.Links)
        .ThenInclude(join => join.Link)
        .FirstOrDefault(tag => tag.TagId == id);
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
      _db.Tags.Remove(thisTag);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}