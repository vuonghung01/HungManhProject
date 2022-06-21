using HungManhProject.Models;
using System.Linq;
using System.Web.Mvc;

namespace HungManhProject.Controllers
{
    public class CollectionsController : Controller
    {
        dbBNGDataContext data = new dbBNGDataContext();
        // GET: collections
        public ActionResult Shop()
        {
            var all_shop = from r in data.Products select r;
            return View(all_shop);
        }

        public ActionResult Jacket()
        {
            var all_jacket = from r in data.Products.Where(x => x.category_id == 2) select r;
            return View(all_jacket);
        }

        public ActionResult TShirt()
        {
            var all_tshirt = from r in data.Products.Where(x => x.category_id == 1) select r;
            return View(all_tshirt);
        }

        public ActionResult HoodieSweater()
        {
            var all_hoodiesweater = from r in data.Products.Where(x => x.category_id == 3) select r;
            return View(all_hoodiesweater);
        }
    }
}