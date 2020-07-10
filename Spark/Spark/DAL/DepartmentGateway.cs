using Spark.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Spark.DAL
{
	public class DepartmentGateway
	{
		private string connectionString =WebConfigurationManager.ConnectionStrings["SparkDb"].ConnectionString;
		public List<Department> GetDepartments()
		{
			SqlConnection conn = new SqlConnection(connectionString);
			SqlCommand cmd = new SqlCommand("SPGetDepartment", conn);
			cmd.CommandType = CommandType.StoredProcedure;
			conn.Open();
			SqlDataReader reader = cmd.ExecuteReader();
			var DepartmentList = new List<Department>();
			while (reader.Read())
			{
				DepartmentList.Add(new Department()
				{
					DepartmentId = Convert.ToInt32(reader["DepartmentId"]),
					Code = reader["Code"].ToString(),
					Name = reader["Name"].ToString()

				});
				
			}
			reader.Close();
			conn.Close();
			return DepartmentList;
		}

	}
}