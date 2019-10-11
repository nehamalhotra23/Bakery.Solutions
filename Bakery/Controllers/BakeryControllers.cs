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

    [HttpGet("/vendorList/{id}")]
    public ActionResult Show(string vendorsListID)
    {
      List<Order> allOrders = Order.GetAll();
      return View(allOrders);
    }
  [HttpGet("/bakery/orders/new")]
  public ActionResult New()
  {
    return View();
  }
  [HttpPost("/bakery/orders")]
  public ActionResult Create(string title, string description, int price, string date)
  {
    Order newOrder = new Order(title, description, price, date);
    return RedirectToAction("Show");
  }


}


}


