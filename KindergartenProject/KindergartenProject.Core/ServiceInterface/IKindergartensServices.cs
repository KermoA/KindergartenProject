using KindergartenProject.Core.Domain;

namespace KindergartenProject.Core.ServiceInterface
{
	public interface IKindergartensServices
	{
		Task<Kindergarten> DetailAsync(Guid id);
	}
}
