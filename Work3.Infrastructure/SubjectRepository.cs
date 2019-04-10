using System;
using System.Collections.Generic;
using System.Text;
using Work3.Core.Entities;

namespace Work3.Infrastructure
{
	public class SubjectRepository : EFRepository<Subject>, ISubjectRepository
	{
		public SubjectRepository(StudentContext dbContext) : base(dbContext)
		{
		}

	}
}
