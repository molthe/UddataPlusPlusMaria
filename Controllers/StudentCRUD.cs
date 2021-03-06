using System;
using System.Collections.Generic;
using UddataPlusPlusMaria.Models;
using UddataPlusPlusMaria.Views;
using System.Data;
using System.Data.SqlClient;


namespace UddataPlusPlusMaria.Controllers
{
    class StudentCRUD
    {
        // works at school
        // const string connectionString = "Data Source=.;Initial Catalog = BuhuZooDB; Integrated Security = True";
        // works at home
        const string connectionString = "Data Source = MARIA\\SQLEXPRESS;Initial Catalog = UddataPlusPlusMaria; Integrated Security = True";

        // SQL - ADD A NEW STUDENT (INSERT)
        public static int? InsertStudent(Student student)
        {
            // Query to insert student
            string sql = "INSERT INTO Student (PersonName, Grade, Warnings) OUTPUT INSERTED.Id VALUES(@PersonName, @Grade, @Warnings)";
            // Create connection
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    // Open connection
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.Add("@PersonName", SqlDbType.NVarChar).Value = student.PersonName;
                        cmd.Parameters.Add("@Grade", SqlDbType.Int).Value = student.Grade;
                        cmd.Parameters.Add("@Warnings", SqlDbType.Int).Value = student.Warnings;

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

        public List<Student> Select()
        {
            List<Student> studentList = new List<Student>();
            string sql = $"SELECT Id, PersonName, Grade, Warnings FROM Student";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        studentList.Add(
                            new Student()
                            {
                                PersonId = (int)reader[0],
                                PersonName = (string)reader[1],
                                Grade = (int)reader[2],
                                Warnings = (int)reader[3],
                            });
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR:" + ex.GetType() + ex.Message);
                    return null;
                }
            }
            return studentList;
        }
    }
}
