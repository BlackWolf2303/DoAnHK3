using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FlowerShop2.Repositories;
using FlowerShop2.Models;

namespace FlowerShop2.Controllers
{
  public class CartController : Controller
  {
    private IProductRepository iProductRepository = new ProductRepository();
    public ActionResult Index()
    {
      return View("Index");
    }
    public ActionResult Buy(int id)
    {
      if (Session["cart"] == null)
      {
        List<Item> cart = new List<Item>();
        cart.Add(new Item()
        {
          product = iProductRepository.find(id),
          quantity = 1
        });
        Session["cart"] = cart;
      }
      else
      {
        List<Item> cart = (List<Item>)(Session["cart"];
        cart.Add(new Item()
        {
          product = iProductRepository.find(id),
          quantity = 1
        });
        Session["cart"] = cart;
      }
      return View(Index);
    }

    public ActionResult Delete(int id)
    {
      List<Item> cart = (List<Item>)(Session["cart"];
      cart.RemoveAt(id);
      Session["cart"] = cart;
      return View("Index");
    }
  }
}