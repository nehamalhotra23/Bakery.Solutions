using System;
using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;

namespace Bakery.Controllers
{
    public class VendorController : Controller
    {
        [HttpGet("/vendor")]
        public ActionResult Index()
        {
            List<Vendor> newList = Vendor.GetAll();
            return View(newList);
        }

        [HttpGet("/vendor/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/vendor")]
        public ActionResult Create(string name, string description)
        {
            Vendor newVendorList = new Vendor(name, description);
            return RedirectToAction("Index");
        }
         [HttpGet("/vendor/{id}")]
        public ActionResult Show(int id)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor vendor = Vendor.Find(id);
            List<Order> orders = vendor.Orders;
            model.Add("vendor", vendor);
            model.Add("order", orders);
            return View(model);
        }
         [HttpPost("/vendor/{vendorID}/order")]
        public ActionResult Create(int vendorID, string title, string description, int price, string date)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor myVendor = Vendor.Find(vendorID);
            Order newOrder = new Order(title, description, price, date);
            myVendor.AddOrder(newOrder);
            List<Order> vendorOrders = myVendor.Orders;
            model.Add("order", vendorOrders);
            model.Add("vendor", myVendor);
            return RedirectToAction("Index");
        }

    }

}


