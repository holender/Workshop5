using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work3.Core.Entities;
using Work3.Core.Interfaces;

namespace Work3.Core
{
	public class SubjectService
	{
		private readonly IAsyncRepository<Subject> _subjectRepo;
		private readonly IAsyncRepository<Teacher> _teacherRepo;
		private readonly IAsyncRepository<Student> _studentRepo;

		public SubjectService(
			IAsyncRepository<Subject> subjectRepo, 
			IAsyncRepository<Teacher> teacherRepo, 
			IAsyncRepository<Student> studentRepo)
		{
			_subjectRepo = subjectRepo;
			_teacherRepo = teacherRepo;
			_studentRepo = studentRepo;
		}

		public async Task CreateSubject(
			Guid teacherId, 
			string subjectName, 
			IEnumerable<Guid> studentsId)
		{
			var teacher = await _teacherRepo.GetByIdAsync(teacherId);

			var students = new List<Student>();
			foreach (var id in studentsId)
			{
				var student = await _studentRepo.GetByIdAsync(id);
				students.Add(student);
			}

			var subject = new Subject(teacher, subjectName, students);
			await _subjectRepo.AddAsync(subject);
		}
	}
}
