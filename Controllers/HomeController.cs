using Microsoft.AspNetCore.Mvc;

namespace razorFun{
    public class HomeController : Controller{
        [HttpGet("")]
        public ViewResult Index(){
            return View();
        }
    }
}