using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstDemo.Models
{
	public class Department
	{
		[Key]
		public int DepartmentId { get; set; }
		[Required(ErrorMessage ="Please enter Department Name.")]
		[StringLength(50)]
		[Display(Name ="Department Name")]
		public string DepartmentName { get; set; }
		[Required(ErrorMessage ="Please enter Department Code")]
		[StringLength(12,MinimumLength =3,ErrorMessage ="Code must be minimum 3 in length.")]
		[Display(Name ="Department Code")]
		public string DepartmentCode { get; set; }
	}
}