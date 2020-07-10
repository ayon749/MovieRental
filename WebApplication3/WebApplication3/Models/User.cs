using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
	public class User
	{
		[Key]
		public int id { get; set; }
		public string Name { get; set; }
		public int age { get; set; }
	}
}