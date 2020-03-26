using Microsoft.AspNetCore.Mvc;
using ResourceLinks.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace ResourceLinks.Controllers
{
  
  public class LinksController : Controller
  {
    private readonly ResourceLinksContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public LinksController(UserManager<ApplicationUser> userManager, ResourceLinksContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Links.ToList());
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

    [Authorize]

    public ActionResult Create()
    {
      ViewBag.CategoryId = new SelectList(_db.Categories, "CategoryId", "Title");
      ViewBag.TagId = new SelectList(_db.Tags, "TagId", "Name");
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Create(Link link, int CategoryId, int TagId)
    { 
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      link.User = currentUser;

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

    [Authorize]

    public ActionResult Edit(int id)
    {
      var thisLink = _db.Links.FirstOrDefault(links => links.LinkId == id);
      return View(thisLink);
    }

    [HttpPost]
    public async Task<ActionResult> Edit(Link link, int CategoryId, int TagId)
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      link.User = currentUser;
      _db.Entry(link).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Details", new {id = link.LinkId});
    }

    [Authorize]
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
      List<Category> selectedCategories =  _db.Categories.OrderBy(x => x.Title).ToList();
      var linkCategories = _db.CategoryLink.Where(c => c.LinkId == id).ToList();
      foreach(CategoryLink element in linkCategories)
      {
        Category thisCategory = _db.Categories.Find(element.CategoryId);
        selectedCategories.Remove(thisCategory);
      }
      ViewBag.CategoryId = new SelectList(selectedCategories, "CategoryId", "Title");
      return View(thisLink);
    }

    [HttpPost]
    public ActionResult AddCategory(Link link, int CategoryId)
    {
      _db.CategoryLink.Add(new CategoryLink() { CategoryId = CategoryId, LinkId = link.LinkId });
      _db.SaveChanges();
      return RedirectToAction("Details", new {id = link.LinkId});
    }

    public ActionResult AddTag(int id)
    {
      Link thisLink = _db.Links.FirstOrDefault(links => links.LinkId == id);
      List<Tag> selectedTags =  _db.Tags.OrderBy(x => x.Name).ToList();
      var linkTags = _db.LinkTag.Where(c => c.LinkId == id).ToList();
      foreach(LinkTag element in linkTags)
      {
        Tag thisTag = _db.Tags.Find(element.TagId);
        selectedTags.Remove(thisTag);
      }
      ViewBag.TagId = new SelectList(selectedTags, "TagId", "Name");
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