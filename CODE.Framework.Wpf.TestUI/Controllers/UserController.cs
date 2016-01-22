using CODE.Framework.Wpf.Mvvm;
using CODE.Framework.Wpf.TestUI.Models.User;

namespace CODE.Framework.Wpf.TestUI.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Login()
        {
            return ViewModal(new LoginViewModel(), ViewLevel.Popup);
        }
    }
}
