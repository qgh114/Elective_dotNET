using Microsoft.AspNetCore.Mvc;


namespace cbsStudents.Controllers;

public class TestsController : Controller
{

public ActionResult WannaPlayDad()
{
    ViewBag.Data = "Hello there";

    return View();
}



}