using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class GameController : Controller
    {
        [HttpPost]
        public IActionResult GuessingNumber(int number)
        {
            if (number != 0)
            {
                ViewBag.Msg = Models.Game.CheckNumber(number);
                return View();
            }
            else
            {
                ViewBag.Msg = "Please enter a number and then submit.";
                return View();
            }
        }


        [HttpGet]
        public IActionResult GuessingNumber()
        {
            return View();
        }
    }
}
