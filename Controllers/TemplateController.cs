using ebay.ViewModelBuilders;
using System.Web.Mvc;

namespace ebay.Controllers
{
    public class TemplateController : Controller
    {
        public TemplateController() { }

        public ActionResult Index(string productName)
        {
            var vmb = new TemplateViewModelBuilder();

            return View(vmb.Build(productName));
        }
    }
}
