using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace UniversityProject.Models
{
	public class UniversityDbCOntext : DbContext
	{
		public DbSet<Department> Departments { get; set; }
		public DbSet<Student> Students { get; set; }

	}
}