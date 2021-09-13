using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UddataPlusPlusMaria.Models;
using UddataPlusPlusMaria.Controllers;

namespace UddataPlusPlusMaria.Views
{
    class MenuView
    {
        public void Menu()
        {

            // creates a menu
            Console.WriteLine("\n *** MAIN MENU *** \n\n" +
                "1. Add a new student\n" +
                "2. Add a new teacher\n" +
                "3. Add a new subject\n" +
                "4. Show all students\n" +
                "5. Show all teachers\n" +
                "6. Show all subjects\n" +
                "7. Search for a student\n" +
                "8. Search for a teacher\n" +
                "9. Search for a subject\n" +
                "To exit: press x");
            string chosenMenuPoint = Console.ReadLine();

            // uses the chosen menu point to call the wanted method. The methods are below this Menu Method
            switch (chosenMenuPoint)
            {
                case "1":
                    AddANewStudentMenu();
                    break;
                case "2":
                    AddANewTeacherMenu();
                    break;
                case "3":
                    // AddSubjects();
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
                case "7":
                    break;
                case "8":
                    break;
                case "9":
                    break;
                case "x":
                    Environment.Exit(0);
                    break;
            }
        }

        private static void AddANewStudentMenu()
        {
            // instantiate the new student
            StudentView stv = new StudentView();
            Student student = stv.AddStudent();
            // insert the new student into the database
            int? Id = StudentCRUD.InsertStudent(student);

            if (Id != null)
            {
                student.PersonId = (int)Id;
                stv.ShowStudent(student);
            }
            else Console.WriteLine("Something went wrong when we tried to add the student to the database!");
        }

        private static void AddANewTeacherMenu()
        {
            // instantiate the new teacher
            TeacherView tcv = new TeacherView();
            Teacher teacher = tcv.AddTeacher();
            // insert the new student into the database
            int? Id = TeacherCRUD.InsertTeacher(teacher);

            if (Id != null)
            {
                teacher.PersonId = (int)Id;
                tcv.ShowTeacher(teacher);
            }
            else Console.WriteLine("Something went wrong when we tried to add the teacher to the database!");
        }
    }
}
