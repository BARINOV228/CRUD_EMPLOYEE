using CRUD_EMPLOYEE.DTO;
using CRUD_EMPLOYEE.Interface;
using CRUD_EMPLOYEE.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_EMPLOYEE.Service
{
    public class EmployeeService : IService
    {
        public static string ConnectionString = "Server = Employee; Database = CRUDEmployee; Trusted_Connection = True;";
        public static void CreateEmployee(Employee e)
        {
            using (SqlConnection connect = new SqlConnection(ConnectionString))
            {
                connect.Open();

                string time = DateTime.Now.ToString("HH:mm:ss");

                var query = $"INSERT INTO Employee (Name, Surname, Email, Login, Password, Status, " +
                    $"Role, CreatedDate) " +
                    $"VALUES ('{e.Name}', '{e.Surname}', '{e.Email}', '{e.Login}', '{e.Password}', '{e.Status}', '{e.Role}', '{time}')";

                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.ExecuteNonQuery();
                Console.WriteLine("User successfully added!");
            }
        }
        public static void GetAllEmployee()
        {
            using (SqlConnection connect = new SqlConnection(ConnectionString))
            {
                connect.Open();

                var query = $"SELECT * FROM Employee " +
                            $"WHERE Status != 'Deleted';";

                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.ExecuteNonQuery();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    bool temp = false;
                    while (reader.Read())
                    {
                        temp = true;
                        Console.WriteLine(reader[0] + " " + reader[1] + " " + reader[2] + " " + reader[3]
                            + " " + reader[7] + " " + reader[8] + " " + reader[9]);
                    }
                    if (temp != true)
                    {
                        Console.WriteLine("Ma'lumot toplimadi!");
                    }
                }
            }
        }
        public static void GetEmployeeById(int id)
        {
            using (SqlConnection connect = new SqlConnection(ConnectionString))
            {
                connect.Open();

                string query = $"SELECT * FROM Employee " +
                               $"WHERE Id = {id} AND Status <> 'Deleted'";

                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.ExecuteNonQuery();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    bool temp = false;
                    while (reader.Read())
                    {
                        temp = true;
                        Console.WriteLine(reader[0] + " " + reader[1] + " " + reader[2] + " " + reader[3]
                            + " " + reader[7] + " " + reader[8] + " " + reader[9]);
                    }
                    if (temp != true)
                    {
                        Console.WriteLine("Ma'lumot toplimadi!");
                    }
                }
            }
        }
        public static void UpdateEmployee(int id, EmployeeDTO e)
        {
            using (SqlConnection connect = new SqlConnection(ConnectionString))
            {
                connect.Open();

                string time = DateTime.Now.ToString("HH:mm:ss");
                var query = $"UPDATE Employee " +
                            $"SET Login = '{e.Login}', Password = '{e.Password}', Role = '{e.Role}', UpdatedDate = '{time}' " +
                            $"WHERE Id = {id} AND Status <> 'Deleted';";

                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Yangilandi!");
            }
        }
        public static void DeleteEmployee(int id)
        {
            using (SqlConnection connect = new SqlConnection(ConnectionString))
            {
                connect.Open();

                string time = DateTime.Now.ToString("HH:mm:ss");
                var query = $"UPDATE Employee " +
                            $"SET Status = 'Deleted', DeletedDate = '{time}'" +
                            $"WHERE Id = {id} AND Status <> 'Deleted';";

                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.ExecuteNonQuery();
                Console.WriteLine("O'chirildi!");
            }
        }
        public static void DeepDelete(int id)
        {
            using (SqlConnection connect = new SqlConnection(ConnectionString))
            {
                connect.Open();

                string query = $"DELETE FROM Employee " +
                               $"WHERE Id = {id} AND Status <> 'Deleted';";

                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Tag-tugi bilan yo'q qilindi :)");
            }
        }
    }
}
