using CODE.Framework.Wpf.Mvvm;
using CODE.Framework.Wpf.TestUI.Models.Demo;

namespace CODE.Framework.Wpf.TestUI.Controllers
{
    public class DemoController : Controller
    {
        public ActionResult List()
        {
            return ViewModal(new ListViewModel());
        }
    }
}
