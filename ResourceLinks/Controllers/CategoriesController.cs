using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ResourceLinks.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ResourceLinks.Controllers
{
  public class CategoriesController : Controller
  {
    private readonly ResourceLinksContext _db;

    public CategoriesController(ResourceLinksContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Categories.ToList());
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
    public ActionResult Create(Category category)
    { 
      List<Category> thisCategories = _db.Categories.ToList();
      int index = 0;
      foreach (Category element in  thisCategories)
      {
        if (element.Title != category.Title && category.Title != null)
        {
          index++;
        }
        if (index == thisCategories.Count)
        {
          _db.Categories.Add(category);
          _db.SaveChanges();
          return RedirectToAction("Index");
        }
      }
      if (category.Title == null)
      {
        TempData ["message"] = "Category Title is empty!";
      }
      else
      {
        TempData ["message"] = "Category already exists!";
      }
      return Create();
    }

    public ActionResult Details(int id)
    {
      var thisCategory = _db.Categories
        .Include(category => category.Links)
        .ThenInclude(join => join.Link)
        .FirstOrDefault(category => category.CategoryId == id);
      return View(thisCategory);
    }

    public ActionResult Edit(int id)
    {
      var thisCategory = _db.Categories.FirstOrDefault(category => category.CategoryId == id);
      return View(thisCategory);
    }

    [HttpPost]
    public ActionResult Edit(Category category)
    {
      _db.Entry(category).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisCategory = _db.Categories.FirstOrDefault(category => category.CategoryId == id);
      return View(thisCategory);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisCategory = _db.Categories.FirstOrDefault(category => category.CategoryId == id);
      _db.Categories.Remove(thisCategory);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}