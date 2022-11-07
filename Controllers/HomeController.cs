using stringReverse.Models;
using System.Web.Mvc;

namespace stringReverse.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Text(TextModel model)
        {

            ViewBag.InputText = this.ReverseString(model.Text);


            return View();
        }

        private string ReverseString(string str)
        {
            if ((str == null) || (str.Length <= 1))
                return str;
            return ReverseString(str.Substring(1)) + str[0];
        }
    }
}