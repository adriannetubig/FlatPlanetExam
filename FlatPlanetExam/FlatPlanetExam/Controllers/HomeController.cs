using System.Linq;
using System.Web.Mvc;
using FlatPlanetExam.Models;

namespace FlatPlanetExam.Controllers
{
    public class HomeController : Controller
    {
        //private Context _ctx = new Context();
        // GET: Home
        public ActionResult Index()
        {
            return View(count());
        }
        public ActionResult Add()
        {
            CounterModel counterModel = new CounterModel();
            using (var ctx = new Context())
            {
                if (count() < 10)
                {
                    ctx.CounterModel.Add(counterModel);
                    ctx.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }

        private int count()
        {
            int count = 0;
            CounterModel counterModel = new CounterModel();
            using (var ctx = new Context())
            {
                count = ctx.CounterModel.Count();
            }
            return count;
        }
    }
}