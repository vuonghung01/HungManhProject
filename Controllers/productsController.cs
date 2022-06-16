using HungManhProject.Models;
using System.Linq;
using System.Web.Mvc;

namespace HungManhProject.Controllers
{
    public class ProductsController : Controller
    {
        dbBNGDataContext data = new dbBNGDataContext();
        // GET: products
        public ActionResult productDetail(int id)
        {
            var detail = data.Products.Where(m => m.product_id == id).First();
            if (detail == null)
            {
                return RedirectToAction("ActionName", "ControllerName");
            }
            return View(detail);
        }
    }
}