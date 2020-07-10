using Spark.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Spark.DAL
{
	public class EmployeeDepartmentGateway
	{
		private string connectionString = WebConfigurationManager.ConnectionStrings["SparkDb"].ConnectionString;

		public List<EmployeeWithDepartment> GetAllEmployees()
		{
			SqlConnection conn = new SqlConnection(connectionString);
			SqlCommand cmd = new SqlCommand("SPGetEmployeesWIthDEpartment", conn);
			cmd.CommandType = CommandType.StoredProcedure;
			conn.Open();
			SqlDataReader reader = cmd.ExecuteReader();
			var employeeList = new List<EmployeeWithDepartment>();
			while (reader.Read())
			{
				employeeList.Add(new EmployeeWithDepartment()
				{
					EmployeeId = Convert.ToInt32(reader["EmployeeId"]),
					EmployeeName = reader["EmployeeName"].ToString(),
					Designation = reader["Designation"].ToString(),
					NID = reader["NID"].ToString(),
					JoiningDate = Convert.ToDateTime(reader["JoiningDate"]),
					BloodGroup = reader["BloodGroup"].ToString(),
					DepartmentId = Convert.ToInt32(reader["DepartmentId"]),
					Code=reader["Code"].ToString(),
					DepartmentName=reader["DepartmentName"].ToString()

				});
			}
			reader.Close();
			conn.Close();
			return employeeList;
		}
	}
}