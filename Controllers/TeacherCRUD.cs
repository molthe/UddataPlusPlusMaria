using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UddataPlusPlusMaria.Models;
using UddataPlusPlusMaria.Views;
using System.Data;
using System.Data.SqlClient;

namespace UddataPlusPlusMaria.Controllers
{
    class TeacherCRUD
    {
        // works at school
        // const string connectionString = "Data Source=.;Initial Catalog = BuhuZooDB; Integrated Security = True";
        // works at home
        const string connectionString = "Data Source = MARIA\\SQLEXPRESS;Initial Catalog = UddataPlusPlusMaria; Integrated Security = True";


        // SQL - ADD A NEW TEACHER (INSERT)
        public static int? InsertTeacher(Teacher teacher)
        {
            // Query to insert student
            string sql = "INSERT INTO Teacher (PersonName, MemberOfTheCoffeeClub ) OUTPUT INSERTED.Id VALUES(@PersonName, @MemberOfTheCoffeeClub)";
            // Create connection
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    // Open connection
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.Add("@PersonName", SqlDbType.NVarChar).Value = teacher.PersonName;
                        cmd.Parameters.Add("@MemberOfTheCoffeeClub", SqlDbType.Int).Value = teacher.MemberOfTheCoffeeClub;

                        var Id = cmd.ExecuteScalar();
                        return (int?)Id;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public List<Teacher> Select()
        {
            List<Teacher> teacherList = new List<Teacher>();
            string sql = $"SELECT Id, PersonName, MemberOfTheCoffeeClub FROM Teacher";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        teacherList.Add(
                            new Teacher()
                            {
                                PersonId = (int)reader[0],
                                PersonName = (string)reader[1],
                                MemberOfTheCoffeeClub = (bool)reader[2],
                            });
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR:" + ex.GetType() + ex.Message);
                    return null;
                }
            }
            return teacherList;
        }
    }
}
