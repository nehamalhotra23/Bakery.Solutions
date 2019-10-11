using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;

namespace Bakery.Controllers
{
  public class VendorListController : Controller
  {
    [HttpGet("/bakery")]
    public ActionResult Index()
    {
      List<VendorList> newList = VendorList.GetAll();
      return View(newList);
    }
  
  [HttpGet("/bakery/new")]
    public ActionResult New()
    {
      return View();
    }
  [HttpPost("/bakery")]
    public ActionResult Create(string name, string description)
    {
      VendorList newVendorList = new VendorList(name, description);
      return RedirectToAction("Index");
    }

}

}


