using Microsoft.AspNetCore.Mvc;

namespace CodeFlowDocumentation.API.Controllers
{
    public class StoredProcedureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
