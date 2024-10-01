﻿using KindergartenProject.Core.Domain;
using KindergartenProject.Core.Dto;

namespace KindergartenProject.Core.ServiceInterface
{
	public interface IKindergartensServices
	{
		Task<Kindergarten> DetailAsync(Guid id);
		Task<Kindergarten> Update(KindergartenDto dto);
	}
}
