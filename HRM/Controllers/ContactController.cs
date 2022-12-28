using Microsoft.AspNetCore.Mvc;

namespace HRM.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}
