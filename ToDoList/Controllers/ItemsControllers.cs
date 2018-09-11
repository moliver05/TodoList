using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers
{
public class ItemsController : Controller
{

  [HttpPost("/items_form")]
  public ActionResult Index()
  {
      List<Item> allItems = new List<Item> {};
      return View(allItems);
  }

  [HttpGet("/items/new")]
  public ActionResult CreateForm()
  {
      return View();
  }

  [HttpPost("/items")]
  public ActionResult Create()
  {
      Item newItem = new Item(Request.Form["new-item"]);
      List<Item> allItems = new List<Item> {};
      return View("Index", allItems);
  }

 }
}
