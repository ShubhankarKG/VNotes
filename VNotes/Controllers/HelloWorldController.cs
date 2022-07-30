using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace VNotes.Controllers;

public class HelloWorldController: Controller 
{
    // 
    // GET: /HelloWorld/

    public string Index()
    {
        return "This is my default action...";
    }

    // 
    // GET: /HelloWorld/Welcome/ 

    public string Welcome(string name = "Alice", int numtimes = 1)
    {
        return HtmlEncoder.Default.Encode($"Welcome {name}, you have visited {numtimes} times");
    }
}