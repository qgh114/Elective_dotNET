
using Microsoft.AspNetCore.Mvc;


namespace cbsStudents.Controllers;

public class PostsController : Controller
{

    public IActionResult Create()
    {
        return View();

    }

public IActionResult Posts()
{

ViewBag.ThankYou = "Thanks For using this application";
return View();
}


}