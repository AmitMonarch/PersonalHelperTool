using Microsoft.AspNetCore.Mvc;

namespace CodeFlowDocumentation.API.Controllers
{
    public class TableController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
