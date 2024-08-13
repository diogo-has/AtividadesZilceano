using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using proj.Models;

namespace proj.Controllers;

public class MessageController : Controller
{
    private static List<Message> messages = new List<Message>();

    [HttpGet]
    public IActionResult Send() {
        return View();
    }

    [HttpPost]
    public IActionResult Send(Message message) {
        messages.Add(message);
        return View(messages);
    }

    public IActionResult Receive() {
        return View(messages);
    }
}
