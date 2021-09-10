//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace UddataPlusPlusMaria.Views
//{
//    class TeacherView
//    {


//        private static void AddTeacher()

//        {
//            Teacher teacher = new Teacher();

//            string memberOfTheClub = "";
//            Console.WriteLine("Type the teacher's name: ");
//            teacher.name = Console.ReadLine();

//            do
//            {

//                Console.WriteLine("Is the teacher member of the coffee club? y/n: ");
//                memberOfTheClub = Console.ReadLine();
//                if (memberOfTheClub == "y")
//                {
//                    teacher.MemberOfTheCoffeeClub = true;
//                }
//                if (memberOfTheClub == "n")
//                {
//                    teacher.MemberOfTheCoffeeClub = false;
//                }

//            } while (memberOfTheClub != "y" && memberOfTheClub != "n");

//            Console.WriteLine("Type the teacher's ID: ");
//            teacher.id = Convert.ToInt32(Console.ReadLine());
//        }
//    }
//}
