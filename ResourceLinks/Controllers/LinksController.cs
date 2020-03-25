using Microsoft.AspNetCore.Mvc;
using ResourceLinks.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace ResourceLinks.Controllers
{
  public class LinksController : Controller
  {
    private readonly ResourceLinksContext _db;

    public LinksController(ResourceLinksContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Links.ToList());
    }

    public ActionResult Create()
    {
      ViewBag.CategoryId = new SelectList(_db.Categories, "CategoryId", "Title");
      ViewBag.TagId = new SelectList(_db.Tags, "TagId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Link link, int CategoryId, int TagId)
    {
      _db.Links.Add(link);
      if (CategoryId != 0)
      {
        _db.CategoryLink.Add(new CategoryLink() { CategoryId = CategoryId, LinkId = link.LinkId });
        
      }
      if (TagId != 0)
      {
        _db.LinkTag.Add(new LinkTag() { TagId = TagId, LinkId = link.LinkId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisLink = _db.Links
        .Include(link => link.Categories)
        .ThenInclude(join => join.Category)
        .Include(link => link.Tags)
        .ThenInclude(join => join.Tag)
        .FirstOrDefault(link => link.LinkId == id);
      return View(thisLink);
    }

    public ActionResult Edit(int id)
    {
      var thisLink = _db.Links.FirstOrDefault(links => links.LinkId == id);
      ViewBag.CategoryId = new SelectList(_db.Categories, "CategoryId", "Title");
      ViewBag.TagId = new SelectList(_db.Tags, "TagId", "Name");
      return View(thisLink);
    }

    [HttpPost]
    public ActionResult Edit(Link link, int CategoryId, int TagId)
    {
      // List<int> category = _db.CategoryLink.Select(CategoryId).ToList();
      if (CategoryId != 0) 
      // && _db.CategoryLink.Find(CategoryId, link.LinkId) != null)
      {
        _db.CategoryLink.Add(new CategoryLink() { CategoryId = CategoryId, LinkId = link.LinkId });
      }
      if (TagId != 0)
      //  && _db.LinkTag.Find(TagId, link.LinkId) != null)
      {
        _db.LinkTag.Add(new LinkTag() { TagId = TagId, LinkId = link.LinkId });
      }
      _db.Entry(link).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Details", new {id = link.LinkId});
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
      Link thisLink = _db.Links.FirstOrDefault(links => links.LinkId == id);
      // var LinkCategories = _db.CategoryLink.Where(c => c.LinkId == id).ToList();
      // foreach(CategoryLink element in LinkCategories)
      // {
      //   Category thisCategory = _db.Categories.Find(element.CategoryId);
      //   allCategories.Remove(thisCategory);
      // }
      // ViewBag.CategoryId = new SelectList(allCategories, "CategoryId", "Title");
      
      List<Category> selectedCategories =  _db.Categories.ToList();

      foreach (Category category in _db.Categories.ToList())
      {
        if (thisLink.Categories.FirstOrDefault(c => c.CategoryId == category.CategoryId) != null)
        {
          selectedCategories.Remove(category);
        }
      }
      
      ViewBag.CategoryId = new SelectList(selectedCategories, "CategoryId", "Title");

      //ViewBag.CategoryId = new SelectList(_db.Categories, "CategoryId", "Title");
      return View(thisLink);
    }

    [HttpPost]
    public ActionResult AddCategory(Link link, int CategoryId)
    {
      if (_db.Categories.FirstOrDefault(c => c.Title == _db.Categories.Find(CategoryId).Title) != null)
      {
        TempData ["message"] = "Category already exists!";
        return RedirectToAction("AddCategory");
      }
      else
      {
        _db.CategoryLink.Add(new CategoryLink() { CategoryId = CategoryId, LinkId = link.LinkId });
        _db.SaveChanges();
        return RedirectToAction("Details", new {id = link.LinkId});
      }
      // if (CategoryId != 0)
      // {

      // }
    }

    public ActionResult AddTag(int id)
    {
      var thisLink = _db.Links.FirstOrDefault(links => links.LinkId == id);
      ViewBag.TagId = new SelectList(_db.Tags, "TagId", "Name");
      return View(thisLink);
    }

    [HttpPost]
    public ActionResult AddTag(Link link, int TagId)
    {
      if (TagId != 0)
      {
        _db.LinkTag.Add(new LinkTag() { TagId = TagId, LinkId = link.LinkId });
      }
      _db.SaveChanges();
      return RedirectToAction("Details", new {id = link.LinkId});
    }    

    [HttpPost]
    public ActionResult DeleteCategory(int joinId)
    {
      var joinEntry = _db.CategoryLink.FirstOrDefault(entry => entry.CategoryLinkId == joinId);
      _db.CategoryLink.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Details", new {id = joinEntry.LinkId});
    }

    [HttpPost]
    public ActionResult DeleteTag(int joinId)
    {
      var joinEntry = _db.LinkTag.FirstOrDefault(entry => entry.LinkTagId == joinId);
      _db.LinkTag.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Details", new {id = joinEntry.LinkId});
    }
  }
}