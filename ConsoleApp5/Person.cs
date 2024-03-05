using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public abstract class Person
    {
        //protected string name;
        //protected string lastname;
        //protected DateTime birth;
        //protected string faculty;

        public string Name
        {
            get;
            set;
        }

        public string Lastname
        {
            get;
            set;
        }

        public DateTime Birth
        {
            get;
            set;
        }

        public string Faculty
        {
            get;
            set;
        }

        public Person(string name, string lastname, DateTime birth, string faculty)
        { 
            this.Name = name;
            this.Lastname = lastname;
            this.Birth = birth;
            this.Faculty = faculty;
        }

        public abstract void Info();
          

        public int Age()
        {
            DateTime now = DateTime.Now;
            int age = now.Year - Birth.Year;
            if (now < Birth.AddYears(age))
                age--;
            return age;

            //return DateTime.Now.Year-Birth.Year;
        }

    }
}
