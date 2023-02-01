using Microsoft.AspNetCore.Mvc;

namespace Vue3SSRdotnet.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        int number = DateTime.Now.Millisecond;
        return View(number);
    }
}
