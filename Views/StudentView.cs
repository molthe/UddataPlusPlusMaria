using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UddataPlusPlusMaria.Models;

namespace UddataPlusPlusMaria.Views
{
    class StudentView
    {
        public Student AddStudent()
        {
            // Adds a student
            Student student = new();
            Console.WriteLine("*** ADD A NEW STUDENT *** ");
            // NAME
            Console.WriteLine("Student's name: ");
            student.PersonName = Console.ReadLine();
            // GRADE
            Console.WriteLine("Student's grade: ");
            student.Grade = Convert.ToInt32(Console.ReadLine());
            // WARNINGS
            Console.WriteLine("Number of warnings recieved: ");
            student.Warnings = Convert.ToInt32(Console.ReadLine());

            return student;
        }
        // this method outputs the object 'student'
        public void ShowStudent(Student student)
        {
            Console.WriteLine("\n\n*** SHOW STUDENT *** ");
            // using System.ComponentModel;
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(student))
            {
                Console.WriteLine($"{descriptor.Name}:{descriptor.GetValue(student)}");
            }
        }

        // this method outputs all students in a list
        public void ShowALLStudents(List<Student> studentList)
        {
            Console.WriteLine("\n\n*** SHOW ALL STUDENTS *** ");
            foreach (var student in studentList)
            {
                // using System.ComponentModel;
                foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(student))
                {
                    Console.WriteLine($"{descriptor.Name}:{descriptor.GetValue(student)}");
                }
            }
        }




        //public Student AddSubjects()
        //{


        //}
        // GetSubject(student);
        //public static void GetSubject(Student str)
        //{
        //    // GET THE SUBJECT
        //    foreach (var subjectType in Enum.GetValues(typeof(Subject.SubjectType)))
        //    {
        //        Console.WriteLine((int)subjectType + " " + subjectType.ToString());
        //    }
        //    Console.WriteLine("SubjectType : ");

        //    Subject.SubjectType p = new Subject.SubjectType();
        //    while (!Enum.TryParse(Console.ReadLine(), out p))
        //    {
        //        Console.WriteLine("Wrong input, try again...");
        //    }
        //    Subject.SubjectType(str) = p;
        //    Console.WriteLine(str.SubjectType);
        //}
    }
}
