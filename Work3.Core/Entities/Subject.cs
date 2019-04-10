using System;
using System.Collections.Generic;
using System.Text;

namespace Work3.Core.Entities
{
	public class Subject : BaseEntity
	{
		public Subject()
		{
			
		}
		public Subject(Teacher teacher, string subjectName, List<Student> students)
		{
			Teacher = teacher;
			SubjectName = subjectName;
			Students = students;
		}

		public string SubjectName { get; set; }
		public Teacher Teacher { get; set; }

		public IEnumerable<Student> Students { get; set; }
	}
}
