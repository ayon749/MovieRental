using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstDemo.Models
{
	public class Student
	{
		[Key]
		public int StudentId { get; set; }
		[Required(ErrorMessage ="Please enter student name")]
		[StringLength(50)]
		public string Name { get; set; }
		[Required(ErrorMessage ="Please enter student registration number.")]
		[Display(Name="Registration Number")]
		public string RegNo { get; set; }

		public int DepartmentId { get; set; }
		[ForeignKey("DepartmentId")]
		[Display(Name="Department Name")]
		public virtual Department Department { get; set; }
	}
}