using Microsoft.AspNetCore.Mvc;

namespace CodeFlowDocumentation.API.Controllers
{
    public class StepController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
