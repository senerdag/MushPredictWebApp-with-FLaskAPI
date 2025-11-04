using Microsoft.AspNetCore.Mvc;

namespace MushPredict.Web.Controllers
{
    public class BinaryController : Controller
    {
        public IActionResult Next()
        {
            int temp;   
            Random digit = new Random();
            int number = digit.Next(1,100);
            temp= number;
            return View(number);
        }
    }
}
