using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();


            //people.Add(new Applicant("John", "Doe", new DateTime(2000, 7, 15), "Engineering"));
            //people.Add(new Student("Alice", "Smith", new DateTime(1998, 3, 20), "Physics", 3));
            //people.Add(new Teacher("Bob", "Johnson", new DateTime(1985, 9, 10), "Mathematics", "Professor", 10));

            //foreach (Person person in people)
            //{
            //    person.Info();
            //}

            bool flag = true;
            while (flag)
            {
                Console.Write("\nВведите название: ");
                string s = Console.ReadLine();
                switch (s)
                {
                    case "Абитуриент":
                        people.Add(Applicant.Input());
                        break;
                    case "Студент":
                        people.Add(Student.Input());
                        break;
                    case "Учитель":
                        people.Add(Teacher.Input());
                        break;
                    case "2":
                        flag = false;
                        break;
                }
                 
                foreach (var elem in people)
                {
                    Console.WriteLine();
                    elem.Info();
                }
             
            }

           
            Console.Write("\nВведите нижнюю границу: ");
            int minAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВведите верхнюю границу: ");
            int maxAge = Convert.ToInt32(Console.ReadLine()); ;

            Console.WriteLine($"\nPeople aged between {minAge} and {maxAge} years:");
            foreach (Person person in people)
            {
                if (person.Age() >= minAge && person.Age() <= maxAge)
                {
                    person.Info();
                }
            }

            Console.ReadKey();
        }
    }
}