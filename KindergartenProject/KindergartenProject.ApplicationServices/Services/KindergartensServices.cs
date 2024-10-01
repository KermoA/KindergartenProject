using KindergartenProject.Core.Domain;
using KindergartenProject.Core.Dto;
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

		public async Task<Kindergarten> Update(KindergartenDto dto)
		{
			Kindergarten domain = new();

			domain.Id = dto.Id;
			domain.GroupName = dto.GroupName;
			domain.ChildrenCount = dto.ChildrenCount;
			domain.KindergartenName = dto.KindergartenName;
			domain.Teacher = dto.Teacher;
			domain.CreatedAt = dto.CreatedAt;
			domain.UpdatedAt = DateTime.Now;

			_context.Kindergartens.Update(domain);
			await _context.SaveChangesAsync();

			return domain;
		}

		public async Task<Kindergarten> Delete(Guid id)
		{
			var kindergarten = await _context.Kindergartens
				.FirstOrDefaultAsync(x => x.Id == id);

			_context.Kindergartens.Remove(kindergarten);
			await _context.SaveChangesAsync();

			return kindergarten;
		}
	}
}
