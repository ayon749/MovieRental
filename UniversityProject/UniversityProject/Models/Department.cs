using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UniversityProject.Models
{
	public class Department
	{
		[Key]
		public int DepartmentId { get; set; }
		[Required(ErrorMessage ="Please enter the name")]
		[StringLength(50,MinimumLength =3,ErrorMessage ="Department name at least 3 characters")]
		[Column(TypeName ="VARCHAR")]
		public string Name { get; set; }
		[Required(ErrorMessage ="please enter correct department code")]
		[StringLength(50,MinimumLength =3,ErrorMessage ="code at least 3 in characters")]
		[Column(TypeName = "VARCHAR")]
		public string Code { get; set; }
	}
}