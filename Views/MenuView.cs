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
                "3. Set subject and grade for a student\n" +
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
                    SetSubjectAndGradeForStudentMenu();
                    break;
                case "4":
                    ShowALLStudentsMenu();
                    break;
                case "5":
                    ShowALLTeachersMenu();
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
        // this method calls the class StudentView and the method AddStudent to add a new student to the database
        // it also shows the input, if it went well
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

        // this method calls the class TeacherView and the method AddTeacher to add a new teacher to the database
        // it also shows the input, if it went well
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
        // this method sets a subject and a grade for a student
        private void SetSubjectAndGradeForStudentMenu()
        {
            SubjectCRUD sql = new SubjectCRUD();
            List<Subject> SubjectList = sql.Select();
            StudentView stv = new Studentview();
            stv.SetSubjectAndGradeForStudent(student);
        }

        // this method calls the StudentCRUD class and the method Select,
        // together with the StudentView class and the method ShowALLStudents to output a list of all the students
        private void ShowALLStudentsMenu()
        {
            StudentCRUD sql = new StudentCRUD();
            List<Student> studentList = sql.Select();
            StudentView stv = new StudentView();
            stv.ShowALLStudents(studentList);
        }


        // this method calls the TeacherCRUD class and the method Select,
        // together with the TeacherView class and the method ShowALLTeachers to output a list of all the teachers
        private void ShowALLTeachersMenu()
        {
            TeacherCRUD sql = new TeacherCRUD();
            List<Teacher> teacherList = sql.Select();
            TeacherView tcv = new TeacherView();
            tcv.ShowALLTeachers(teacherList);
        }
    }
}
