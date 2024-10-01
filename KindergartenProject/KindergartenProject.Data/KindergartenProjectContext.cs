using KindergartenProject.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace KindergartenProject.Data
{
	public class KindergartenProjectContext : DbContext
	{
		public KindergartenProjectContext(DbContextOptions<KindergartenProjectContext> options) 
			: base(options) { }

		public DbSet<Kindergarten> Kindergartens { get; set; }
	}
}
