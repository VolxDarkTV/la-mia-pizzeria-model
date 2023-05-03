using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            using (PizzaContext db = new PizzaContext())
            {
                List<Pizza> pizza = db.pizze.ToList<Pizza>();
                return View(pizza);
            }
        }

        public IActionResult Details(int id)
        {
            using PizzaContext db = new PizzaContext();
            Pizza pizza = db.pizze.FirstOrDefault(m => m.Id == id);
            return View("Show", pizza);
        }



        /*public IActionResult Add()
        {
            using PizzaContext db = new PizzaContext();
            Pizza pizza = new Pizza();
            db.Add(pizza);
            db.SaveChanges();

            return View();
        }
        */
    }
}
