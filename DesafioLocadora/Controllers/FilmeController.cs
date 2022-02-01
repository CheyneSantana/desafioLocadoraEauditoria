using Microsoft.AspNetCore.Mvc;

namespace DesafioLocadora.Controllers
{
    public class FilmeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
