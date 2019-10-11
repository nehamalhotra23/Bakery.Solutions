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
  }
}