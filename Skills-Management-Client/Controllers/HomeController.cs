using System.Threading.Tasks;
using System.Web.Mvc;

namespace Skills_Management_Client.Controllers {
	public class HomeController : Controller {
		async public Task<ActionResult> Index() {
			string json = await API.getSkills();
			ViewBag.json = json;
			return View(json);
		}

		public ActionResult About() {
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact() {
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}