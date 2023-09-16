using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject
{
    internal class Student
    {
        private int studentNo;
        private string studentName;
        private string studentLastName;
        private float vize1;
        private float vize2;
        private float final;
        private string schoolName;

        public Student(int studentNo, string studentName, string studentLastName, float vize1, float vize2, float final, string schoolName)
        {
            this.studentNo = studentNo;
            this.studentName = studentName;
            this.studentLastName = studentLastName;
            this.vize1 = vize1;
            this.vize2 = vize2;
            this.final = final;
            this.schoolName = schoolName;
        }

        public void showStudentInformation()
        {
            Console.WriteLine("Student no : " + studentNo);
            Console.WriteLine("Student name : " + studentName);
            Console.WriteLine("Student last name : " + studentLastName);
            Console.WriteLine("Student first exam : " + vize1);
            Console.WriteLine("Student second exam : " + vize2);
            Console.WriteLine("Student final exam : " + final);
            Console.WriteLine("Student school name : " + schoolName);
        }
        public void calculateScore()
        {
            Console.WriteLine("Student school score is " + ((vize1 * 0.3) + (vize2 * 0.3) + (final * 0.4)));
        }
        public void showStudentSchool()
        {
            Console.WriteLine("Student's school is " + schoolName);
        }
    }
}
