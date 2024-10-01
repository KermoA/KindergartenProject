using KindergartenProject.Core.Domain;
using KindergartenProject.Core.ServiceInterface;
using KindergartenProject.Data;
using Microsoft.EntityFrameworkCore;

namespace KindergartenProject.ApplicationServices.Services
{
	public class KindergartensServices : IKindergartensServices
	{
		private readonly KindergartenProjectContext _context;

		public KindergartensServices
			(
				KindergartenProjectContext context
			)
		{
			_context = context;
		}

		public async Task<Kindergarten> DetailAsync(Guid id)
		{
			var result = await _context.Kindergartens
				.FirstOrDefaultAsync(x => x.Id == id );

			return result;
		}
	}
}
