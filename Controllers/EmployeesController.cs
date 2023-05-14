using Microsoft.AspNetCore.Mvc;

namespace ToDo_DotNet.Controllers
{
    public class EmployeesController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }



    }
}
