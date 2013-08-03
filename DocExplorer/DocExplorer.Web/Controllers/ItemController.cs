using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DocExplorer.Models;

namespace DocExplorer.Web.Controllers {
  public class ItemController : Controller {

    public ActionResult Index() {
      return View();
    }

    public ActionResult Create() {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Item item) {
      return View();
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
