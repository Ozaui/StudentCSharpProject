using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(1, "Özay", "Yıldız", 70f, 60f, 85f, "SDU");

            int option;
            while (true) 
            {
                Console.WriteLine("Please choose one of the selection");
                Console.WriteLine("1 => Show student information");
                Console.WriteLine("2 => Calculate score");
                Console.WriteLine("3 => show student school");
                Console.WriteLine("4 => Exit");

                option = Convert.ToInt32(Console.ReadLine());

                if (option == 1) 
                {
                    student.showStudentInformation();
                }else if(option == 2)
                {
                    student.calculateScore();
                }else if (option == 3)
                {
                    student.showStudentSchool();
                }else if(option == 4)
                {
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
