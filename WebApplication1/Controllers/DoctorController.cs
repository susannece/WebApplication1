using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class DoctorController : Controller
    {
        [HttpPost]
        public IActionResult TestFever(double temp)
        {
            if (temp != 0)
            {
                ViewBag.Msg = Models.Doctor.TestFever(temp);
                return View();
            }
            else
            {
                ViewBag.Msg = "Please enter temperature and then submit.";
                return View(); 
            }
        }
  

        [HttpGet]
        public IActionResult TestFever()
        {
            return View();
        }
    }
}
