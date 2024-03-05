using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Teacher:Person
    {
        //protected string position;
        //protected int experience;

        public string Position
        {
            get;
            set;
        }

        public int Experience
        {
            get;
            set;
        }

        public Teacher(string name, string lastname, DateTime birth, string faculty, string position, int experience) : base(name, lastname, birth, faculty)
        {
            this.Position = position;
            this.Experience = experience;
        }

        public override void Info()
        {
            Console.WriteLine($"Applicant: {Name} {Lastname}");
            Console.WriteLine($"Birth: {Birth.ToShortDateString()}");
            Console.WriteLine($"Faculty:{Faculty}");
            Console.WriteLine($"Position: {Position}");
            Console.WriteLine($"Experience: {Experience}");
            Console.WriteLine($"Age: {Age()}");

        }

        public static Teacher Input()
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("введите фамилию: ");
            string lastname = Console.ReadLine();
            Console.Write("Введите возраст: ");
            DateTime birth = DateTime.Parse(Console.ReadLine());
            Console.Write("Введите факультет: ");
            string faculty = Console.ReadLine();
            Console.Write("Введите должность: ");
            string position = Console.ReadLine();
            Console.Write("введите стаж: ");
            int experience = Convert.ToInt32(Console.ReadLine());
            return new Teacher(name, lastname, birth, faculty, position, experience);
        }
    }
}
