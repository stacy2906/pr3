using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Applicant:Person
    {
        public Applicant(string name, string lastname, DateTime birth, string faculty) : base(name, lastname, birth, faculty)
        {
           
        }

        public override void Info()
        {
            Console.WriteLine($"Applicant: {Name} {Lastname}");
            Console.WriteLine($"Birth: {Birth.ToShortDateString()}");
            Console.WriteLine($"Faculty:{Faculty}");
            Console.WriteLine($"Age: {Age()}");
        }
        public static Applicant Input()
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("введите фамилию: ");
            string lastname = Console.ReadLine();
            Console.Write("Введите возраст: ");
            DateTime birth = DateTime.Parse(Console.ReadLine());
            Console.Write("Введите факультет: ");
            string faculty = Console.ReadLine();
            return new Applicant(name, lastname, birth, faculty);
        }

    }
}
