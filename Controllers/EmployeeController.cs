 using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult  Index1()
        {
            return view();
        }
        public ViewResult Index2()
        {
            return View("Index");
        }
        public ActionResult Index3()
        {
            return Content("Employee");
        }
    }
}
