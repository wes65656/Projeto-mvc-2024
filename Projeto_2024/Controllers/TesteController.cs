using Microsoft.AspNetCore.Mvc;

namespace Projeto_2024.Controllers;

public class TesteController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Demo()
    {
        return View();
    }
}