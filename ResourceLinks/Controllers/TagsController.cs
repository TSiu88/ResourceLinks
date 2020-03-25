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
      if (tag.Name == null)
      {
        TempData ["message"] = "Tag Name is empty!";
        return Create();
      }
      else if (_db.Tags.FirstOrDefault(t => t.Name.ToLower() == tag.Name.ToLower()) != null)
      {
        TempData ["message"] = "Tag already exists!";
        return Create();
      }
      else
      {
        _db.Tags.Add(tag);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
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
      if(TempData["message"] != null)
      {
        ViewBag.Message = TempData["message"].ToString();
        TempData["message"] = null;
      }
      var thisTag = _db.Tags.FirstOrDefault(tag => tag.TagId == id);
      return View(thisTag);
    }

    [HttpPost]
    public ActionResult Edit(Tag tag)
    {
      if (tag.Name == null)
      {
        TempData ["message"] = "Tag Name is empty!";
        return RedirectToAction("Edit");
      }
      else if (tag.Name == _db.Tags.Find(tag.TagId).Name)
      {
        return RedirectToAction("Index");
      }
      else if (_db.Tags.FirstOrDefault(t => t.Name.ToLower() == tag.Name.ToLower()) != null)
      {
        TempData ["message"] = "Tag already exists!";
        return Create();
      }
      else
      {
        _db.Entry(tag).State = EntityState.Modified;
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
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