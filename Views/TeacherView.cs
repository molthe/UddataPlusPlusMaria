using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UddataPlusPlusMaria.Models;
using System.ComponentModel;

namespace UddataPlusPlusMaria.Views
{
    class TeacherView
    {
        public Teacher AddTeacher()
        {
            Teacher teacher = new Teacher();

            string memberOfTheClub = "";
            Console.WriteLine("Type the teacher's name: ");
            teacher.PersonName = Console.ReadLine();

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

            } while (memberOfTheClub != "y" && memberOfTheClub != "n");

            return teacher;
        }


        // this method outputs the object 'teacher'
        public void ShowTeacher(Teacher teacher)
        {
            Console.WriteLine("\n\n*** SHOW TEACHER *** ");
            // using System.ComponentModel;
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(teacher))
            {
                Console.WriteLine($"{descriptor.Name}:{descriptor.GetValue(teacher)}");
            }
        }

        // this method outputs all teachers in a list
        public void ShowALLTeachers(List<Teacher> teacherList)
        {
            Console.WriteLine("\n\n*** SHOW ALL TEACHERS *** ");
            foreach (var teacher in teacherList)
            {
                // using System.ComponentModel;
                foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(teacher))
                {
                    Console.WriteLine($"{descriptor.Name}:{descriptor.GetValue(teacher)}");
                }
                
            }
        }
    }
}
