using Microsoft.AspNetCore.Mvc;

namespace CodeFlowDocumentation.API.Controllers
{
    public class ApiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
