using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Work3.Core.Entities;

namespace Work3.Infrastructure
{
	public class StudentContext : DbContext
	{
		public StudentContext(
			DbContextOptions<StudentContext> options)
			: base(options)
		{
		
		}

		public DbSet<Student> Students { get; set; }
		public DbSet<Teacher> Teachers { get; set; }
		public DbSet<Subject> Subjects { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Entity<Student>(ConfigureStudent);
			builder.Entity<Teacher>();
			builder.Entity<Subject>();
		}

		private void ConfigureStudent(EntityTypeBuilder<Student> builder)
		{
			builder.ToTable("Student");
			builder.Property(ci => ci.Id)
				.IsRequired();
		}
	}
}
