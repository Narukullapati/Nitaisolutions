using System.Web.Mvc;
using Nitaisolutions.Models;
using Nitaisolutions.NitaiDB;

namespace Nitaisolutions.Controllers
{
    public class LoginController : Controller
    {
        DBEngine DBE = new DBEngine();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
       
    }
}