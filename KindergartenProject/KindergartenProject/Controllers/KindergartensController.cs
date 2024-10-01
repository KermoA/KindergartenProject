using Microsoft.AspNetCore.Mvc;

namespace KindergartenProject.Controllers
{
	public class KindergartensController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
