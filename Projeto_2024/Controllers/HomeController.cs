using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Projeto_2024.Models;

namespace Projeto_2024.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}