using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Student:Person
    {
        //protected int course;

        public int Course
        {
            get;
            set;
        }
        public Student(string name, string lastname, DateTime birth, string faculty, int course):base(name, lastname, birth,faculty)
        {
            this.Course = course;
        }

        public override void Info()
        {
            Console.WriteLine($"Applicant: {Name} {Lastname}");
            Console.WriteLine($"Birth: {Birth.ToShortDateString()}");
            Console.WriteLine($"Faculty:{Faculty}");
            Console.WriteLine($"Course: {Course}");
            Console.WriteLine($"Age: {Age()}");
          
        }

        public static Student Input()
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("введите фамилию: ");
            string lastname = Console.ReadLine();
            Console.Write("Введите возраст: ");
            DateTime birth = DateTime.Parse(Console.ReadLine());
            Console.Write("Введите факультет: ");
            string faculty = Console.ReadLine();
            Console.Write("Введите курс: ");
            int course = Convert.ToInt32(Console.ReadLine());
            return new Student(name, lastname, birth, faculty,course);
        }
    }
}
