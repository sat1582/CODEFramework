using CODE.Framework.Wpf.Mvvm;
using CODE.Framework.Wpf.TestUI.Models.Home;

namespace CODE.Framework.Wpf.TestUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Start()
        {
            return Shell(new StartViewModel(), "Business Application");
        }
    }
}
