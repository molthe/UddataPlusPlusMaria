using System;
using UddataPlusPlusMaria.Views;

namespace UddataPlusPlusMaria
{
    // this program uses class and inheritance. The classes Teacher and Student derive from the base class Person.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" *** WELCOME TO THE SCHOOL PAGE ***");
            while (true)
                new MenuView().Menu();
        }
    }
}
