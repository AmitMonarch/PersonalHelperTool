using Microsoft.AspNetCore.Mvc;

namespace CodeFlowDocumentation.API.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
