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
    }
}