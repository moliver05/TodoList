using Microsoft.AspNetCore.Mvc;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost("/items_form")]
    public ActionResult ToDoList()
    {
      Values myValues = new Values();
      myValues.SetDescription(Request.Query["new-item"]);


      return View("Index", myValues);
    }
    }
}
