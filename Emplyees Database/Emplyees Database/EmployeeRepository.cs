using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Common;

namespace Emplyees_Database
{


    class EmployeeRepository
    {
        DbProviderFactory factory;
        string provider;
        string connectionString;
        public EmployeeRepository()
        {
            provider = ConfigurationManager.AppSettings["provider"];
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            factory = DbProviderFactories.GetFactory(provider);
        }

        public List<Employee> GetAll()
        {
            var employees = new List<Employee>();
            using(var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = "Select * From Employees;";
                using(DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        employees.Add(new Employee { 
                        id = (int) reader["Id"],
                        FirstName = (string)reader["FirstName"],
                        LastName = (string)reader["LastName"]
                        });
                    }
                }
            }
            return employees;
        }
   
    
    public void Add(Employee employee)
        {
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Insert Into Employees (FirstName, LastName) Values ('{employee.FirstName}','{employee.LastName}');";

                command.ExecuteNonQuery();
            }
        }

        public void Update(Employee employee)
        {
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Update Employees Set  FirstName = '{employee.FirstName}', LastName = '{employee.LastName}' Where Id = '{employee.id}' ;";

                command.ExecuteNonQuery();
            }
        }


        public void Delete(int id)
        {
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Delete From Employees   Where Id = {id} ;";

                command.ExecuteNonQuery();
            }
        }


    }
}
