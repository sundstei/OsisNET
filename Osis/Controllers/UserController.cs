using System.Web.Mvc;
using Osis.Models;

namespace Osis.Controllers
{
    public class UserController : Controller
    {
        // GET: /User/

        public ActionResult Index(User user)
        {
            user.Password = "this is hardcoded";

            return View(user);
        }

    }
}
