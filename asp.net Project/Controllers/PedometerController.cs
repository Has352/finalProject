using Microsoft.AspNetCore.Mvc;
using asp.net_Project.Models;
namespace asp.net_Project.Controllers
{
    public class PedometerController : Controller
    {
        private StepsDbContext _sdb;
        public PedometerController( StepsDbContext sdb )
        {
            _sdb = sdb;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Steps()
        {
            ViewData["error"] = "";

            return View();
        }

        [HttpPost]
        public IActionResult StepsToCalories(StepsModel step)
        {

            if (step.stepsNum <= 0)
            {
                ViewData["error"] = "Not allowed less than 0 value";
                return View("Steps");
            }
            else
            {
                step.dates = DateTime.Now;
                _sdb.StepsM.Add(step);
                _sdb.SaveChanges();
                double total = step.stepsNum * 0.04;
                return View(total);
            }

        }
    }
}
