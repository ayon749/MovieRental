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
	public class EmployeeGateway
	{
		private string connectionString = WebConfigurationManager.ConnectionStrings["SparkDb"].ConnectionString;

		public List<Employee> GetAllEmployees()
		{
			SqlConnection conn = new SqlConnection(connectionString);
			SqlCommand cmd = new SqlCommand("SPGetAllEmployee", conn);
			cmd.CommandType = CommandType.StoredProcedure;
			conn.Open();
			SqlDataReader reader = cmd.ExecuteReader();
			var employeeList = new List<Employee>();
			while (reader.Read())
			{
				employeeList.Add(new Employee()
				{
					EmployeeId = Convert.ToInt32(reader["EmployeeId"]),
					Name = reader["Name"].ToString(),
					Designation = reader["Designation"].ToString(),
				    NID = reader["NID"].ToString(),
					JoiningDate=Convert.ToDateTime(reader["JoiningDate"]),
					BloodGroup=reader["BloodGroup"].ToString(),
					DepartmentId=Convert.ToInt32(reader["DepartmentId"])
					
				});
			}
			reader.Close();
			conn.Close();
			return employeeList;
		}

		public bool SaveEmployee(Employee employee)
		{
			SqlConnection conn = new SqlConnection(connectionString);
			SqlCommand cmd = new SqlCommand("SPSaveEmployee", conn);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("@Name", employee.Name);
			cmd.Parameters.AddWithValue("@Designation", employee.Designation);
			cmd.Parameters.AddWithValue("@NID", employee.NID);
			cmd.Parameters.AddWithValue("@JoiningDate", employee.JoiningDate);
			cmd.Parameters.AddWithValue("@BloodGroup", employee.BloodGroup);
			cmd.Parameters.AddWithValue("@DepartmentId", employee.DepartmentId);
			conn.Open();
			int rowEffect=cmd.ExecuteNonQuery();
			conn.Close();
			if(rowEffect>0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}