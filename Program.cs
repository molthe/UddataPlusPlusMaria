using System;

namespace UddataPlusPlusMaria
{
    class Program
    {
        static void Main(string[] args)
        {

            // this program uses class and inheritance. The classes Teacher and Student derive from the base class Person

            // instantiate the class student
            Student student = new Student();
            // instantiate the class teacher
            Teacher teacher = new Teacher();

            //AddStudent(student);
            AddTeacher(teacher);



        }

        private static void AddStudent(Student student)
        {
            Console.WriteLine("Type the student's name: ");
            student.name = Console.ReadLine();
            Console.WriteLine("Type the student's grade: ");
            student.grade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type the amount of warnings the student has recieved: ");
            student.warnings = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type the student's ID: ");
            student.id=Convert.ToInt32(Console.ReadLine());
        }

        private static void AddTeacher(Teacher teacher)
        {
            string memberOfTheClub = "";
            Console.WriteLine("Type the teacher's name: ");
            teacher.name = Console.ReadLine();

            do
            {
            
            Console.WriteLine("Is the teacher member of the coffee club? y/n: ");
            memberOfTheClub = Console.ReadLine();
            if (memberOfTheClub == "y")
            {
                teacher.MemberOfTheCoffeeClub = true;
            }
            if (memberOfTheClub == "n")
            {
                teacher.MemberOfTheCoffeeClub = false;
            }

            } while (memberOfTheClub!="y" && memberOfTheClub!= "n"); 
            
            Console.WriteLine("Type the teacher's ID: ");
            teacher.id = Convert.ToInt32(Console.ReadLine());
        }
    }
}
