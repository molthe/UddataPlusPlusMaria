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

    class SubjectCRUD
    {
        // works at school
        // const string connectionString = "Data Source=.;Initial Catalog = BuhuZooDB; Integrated Security = True";
        // works at home
        const string connectionString = "Data Source = MARIA\\SQLEXPRESS;Initial Catalog = BuhuZooDB; Integrated Security = True";

        public static void SetSubjectAndGradeForStudent(Student student)
        {
            // Query to set grade and subject for student
            string sql = $"UPDATE Student WHERE id = {student.PersonId} (Subject, Grade) VALUES(@SubjectID, @Grade)";
            // Create connection
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    // Open connection
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.Add("@SubjectID", SqlDbType.NVarChar).Value = student.SubjectID;
                        cmd.Parameters.Add("@Grade", SqlDbType.Int).Value = student.Grade;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public List<Subject> Select()
        {
            List<Subject> subjectList = new List<Subject>();
            string sql = $"SELECT Id, SubjectName FROM Subject";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        subjectList.Add(
                            new Subject()
                            {
                                SubjectID = (int)reader[0],
                              //  Subject.SubjectName = (Subject.SubjectName)Enum.Parse(typeof(Subject.SubjectName), reader[1].ToString()),
                            });
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR:" + ex.GetType() + ex.Message);
                    return null;
                }
            }
            return subjectList;
        }
    }
}
