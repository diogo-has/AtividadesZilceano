using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using proj.Models;

namespace proj.Controllers;

public class MessageController : Controller
{
    [HttpGet]
    public IActionResult Index() {
        return View();
    }

    [HttpPost]
    public IActionResult Index(Message message) {
        ViewBag.Message = message.Content;
        return View();
    }
}
