using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace VNotes.Controllers;

public class HelloWorldController: Controller 
{
    // 
    // GET: /HelloWorld/

    public IActionResult Index()
    {
        return View();
    }

    // 
    // GET: /HelloWorld/Welcome/ 

    public IActionResult Welcome(string name = "Alice", int numtimes = 1)
    {
        ViewData["Message"] = $"Hello {name}";
        ViewData["NumTimes"] = numtimes;

        return View();
    }
}