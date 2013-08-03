using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DocExplorer.Models;

namespace DocExplorer.Web.Controllers {
  public class ItemController : Controller {

    private DocContext db = new DocContext();
    protected override void Dispose(bool disposing) {
      db.Dispose();
      base.Dispose(disposing);
    }

    public ActionResult Index() {
      var q = from i in db.Items
              orderby i.DateCreated ascending
              select i;
      var items = q.ToList();
      return View(items);
    }

    public ActionResult Create() {
      return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(Item item, HttpPostedFileBase uploadFile) {
      if (uploadFile == null) {
        ModelState.AddModelError("uploadFile", "Please choose a file to upload with");
      }
      if (ModelState.IsValid) {
        db.Items.Add(item);
        db.SaveChanges();

        return RedirectToAction("Index");
      }
      return View(item);
    }

    public ActionResult Edit() {
      return View();     
    }                    
                         
    [HttpPost]           
    public ActionResult Edit(Item item) {
      return View();
    }

    public ActionResult Browse(string itemId, string fileId) {
      return View();
    }
  }
}
