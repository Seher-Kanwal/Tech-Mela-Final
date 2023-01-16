using Microsoft.AspNetCore.Mvc;

namespace Tech_Mela_Final.Controller
{
    public class FormHandlerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
