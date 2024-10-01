using KindergartenProject.Data;
using KindergartenProject.Models.Kindergartens;
using Microsoft.AspNetCore.Mvc;

namespace KindergartenProject.Controllers
{
	public class KindergartensController : Controller
	{
		private readonly KindergartenProjectContext _context;

		public KindergartensController
			(
				KindergartenProjectContext context
			)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			var result = _context.Kindergartens
				.Select(x => new KindergartensIndexViewModel
				{
					Id = x.Id,
					GroupName = x.GroupName,
					ChildrenCount = x.ChildrenCount,
					KindergartenName = x.KindergartenName,
					Teacher = x.Teacher
				});

			return View(result);
		}
	}
}
