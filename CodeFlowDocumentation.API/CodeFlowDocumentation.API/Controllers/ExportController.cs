using Microsoft.AspNetCore.Mvc;

namespace CodeFlowDocumentation.API.Controllers
{
    public class ExportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
