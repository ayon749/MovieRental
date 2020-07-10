using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UniversityProject.Models
{
	public class Student
	{
		[Key]
		public int StudnetId { get; set; }
		[Required(ErrorMessage = "Please enter the name")]
		[StringLength(50)]
		public string Name { get; set; }
		[Required(ErrorMessage = "Please enter the registration number.")]
		[StringLength(20, MinimumLength = 3, ErrorMessage = "Registration  number should be more than 3 characters.")]
		public string RegNo { get; set; }
		[DataType(DataType.MultilineText)]
		public string Address { get; set; }
		[Range(18, 99, ErrorMessage = "Age must be between 18 to 99.")]
		public int Age { get; set; }

		public int DepartmentId { get; set; }
		[ForeignKey("DepartmentId")]
		public virtual Department Department { get; set; }
	}
}