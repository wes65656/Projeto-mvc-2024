using Microsoft.AspNetCore.Mvc;

namespace Projeto_2024.Controllers;

public class TestController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}