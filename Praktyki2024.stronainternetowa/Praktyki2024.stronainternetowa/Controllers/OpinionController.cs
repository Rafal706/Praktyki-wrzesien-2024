using Microsoft.AspNetCore.Mvc;
using Praktyki2024.stronainternetowa.Models;

namespace Praktyki2024.stronainternetowa.Controllers
{
    public class OpinionController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(OpinionFormModel model)
        {
            if (ModelState.IsValid)
            {

                return RedirectToAction("ThankYou");
            }
            return View(model);
        }


        public ActionResult ThankYou()
        {
            return View();
        }
    }
}
