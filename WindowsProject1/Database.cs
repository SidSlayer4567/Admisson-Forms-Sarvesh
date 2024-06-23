using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace WindowsProject1
{
    internal class Database
    {
        private string connectionString = "Server=SID\\SQLEXPRESS;Database=myApp;Trusted_Connection=True;TrustServerCertificate=true";

        public void SaveApplicant(string firstName, string lastName, int age, DateTime birthDate, String gender,string phoneNum,String Email, String Major)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string insertQuery = "INSERT INTO Applicants (FirstName, LastName, Age, BirthDate, Gender, PhoneNumber, eMailAddress,Major) VALUES (@firstName, @lastName, @age, @birthDate, @gender,@phoneNum,@Email,@Major)";
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@age", age);
                    command.Parameters.AddWithValue("@birthDate", birthDate);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@phoneNum", phoneNum);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Major", Major);
                    command.ExecuteNonQuery();

                }
                
            }
        }

        public DataTable GetUsers()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT * FROM Applicants";
                using (var adapter = new SqlDataAdapter(selectQuery, connection))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
    }
}

