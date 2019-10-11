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

    [HttpGet("/bakery/{id}")]
    public ActionResult Show(string vendorListID)
    {
      int intID = int.Parse(vendorListID);
      VendorList newVendor = VendorList.Show(intID);
      return View(newVendor);
    }
  [HttpGet("/bakery/{id}/orders/new")]
  public ActionResult NewOrder()
  {
     List<Order> newOrder = Order.GetAll();
     return View(newOrder);
    
  }
  [HttpPost("/bakery/{id}/orders/new")]
  public ActionResult Create(string title, string description, int price, string date)
  {
    Order newOrder = new Order(title, description, price, date);
    return RedirectToAction("Index");
  }


}


}


