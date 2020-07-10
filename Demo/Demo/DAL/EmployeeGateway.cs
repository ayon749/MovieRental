using Demo.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Demo.DAL
{
	public class EmployeeGateway
	{
		private string connectionString = WebConfigurationManager.ConnectionStrings["DemoDb"].ConnectionString;
		public List<Employee> GetAllEmployee()
		{
			SqlConnection conn = new SqlConnection(connectionString);
			string query = "SELECT * FROM Employees";
			SqlCommand command = new SqlCommand(query, conn);
			conn.Open();
			SqlDataReader reader = command.ExecuteReader();
			List<Employee> employees = new List<Employee>();
			while(reader.Read())
			{
				employees.Add(new Employee()
				{
					EmployeeId = Convert.ToInt32(reader["EmployeeId"]),
					EmployeeName = reader["EmplyeeName"].ToString(),
					Designation = reader["Designation"].ToString(),
					email = reader["email"].ToString(),
					age=Convert.ToInt32(reader["age"]),
					MobileNo=Convert.ToInt32(reader["MobileNo"])

				});

			}
			reader.Close();
			conn.Close();
			return employees;

		}

		public bool SaveEmployee(Employee employee)
		{
			SqlConnection conn = new SqlConnection(connectionString);
			string query = "INSERT INTO Employees VALUES(@EmployeeName,@Designation,@email,@age,@MobileNo)";
			SqlCommand cmd = new SqlCommand(query, conn);
			conn.Open();
			cmd.Parameters.Add("EmployeeName", SqlDbType.VarChar);
			cmd.Parameters["EmployeeName"].Value = employee.EmployeeName;

			cmd.Parameters.Add("Designation", SqlDbType.VarChar);
			cmd.Parameters["Designation"].Value = employee.Designation;

			cmd.Parameters.Add("email", SqlDbType.VarChar);
			cmd.Parameters["email"].Value = employee.email;

			cmd.Parameters.Add("age", SqlDbType.Int);
			cmd.Parameters["age"].Value = employee.age;

			cmd.Parameters.Add("MobileNo", SqlDbType.VarChar);
			cmd.Parameters["MobileNo"].Value = employee.MobileNo;

			int rowEffect=cmd.ExecuteNonQuery();
			conn.Close();
			if (rowEffect > 0)
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