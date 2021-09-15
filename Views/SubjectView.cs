using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using UddataPlusPlusMaria.Models;

namespace UddataPlusPlusMaria.Views
{
    class SubjectView
    {
        //set subject and grade for student
        public Student student()
        {
            // 
            ShowALLSubjects(subjectList);

            Student student = new();
            Console.WriteLine("*** ADD INFORMATION TO A STUDENT *** ");
            // Asks which ID should get a subject and grade
            Console.WriteLine("Write the ID of the student you want to edit: ");
            student.PersonId = Convert.ToInt32(Console.ReadLine());
            // Asks what subject they should get
            Console.WriteLine("Set subject: ");
            student.SubjectID = Convert.ToInt32(Console.ReadLine());
            // Asks what grade they should get
            Console.WriteLine("Set grade: ");
            student.Grade = Convert.ToInt32(Console.ReadLine());

            return student;
        }

        // this method outputs the object 'subject'
        public void ShowSubject(Subject subject)
        {
            Console.WriteLine("\n\n*** SHOW SUBJECT *** ");
            // using System.ComponentModel;
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(subject))
            {
                Console.WriteLine($"{descriptor.Name}:{descriptor.GetValue(subject)}");
            }
        }
        //this method outputs all subjects in a list
        public void ShowALLSubjects(List<Subject> subjectList)
        {
            Console.WriteLine("\n\n*** SHOW ALL SUBJECTS *** ");
            foreach (var subject in subjectList)
            {
                // using System.ComponentModel;
                foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(subject))
                
                    Console.WriteLine($"{descriptor.Name}:{descriptor.GetValue(subject)}");
                }
            }
        }
        }