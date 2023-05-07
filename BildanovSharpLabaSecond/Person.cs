using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BildanovSharpLabaSecond
{
    class Person
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        private DateTime birthDate;
        public char Ben { get; set; }

        public Person() { }

        public Person(string lastName, string firstName, DateTime birthDate, char ben)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.BirthDate = birthDate;
            this.Ben = ben;
        }

        public Person(Person p)
        {
            this.LastName = p.LastName;
            this.FirstName = p.FirstName;
            this.BirthDate = p.BirthDate;
            this.Ben = p.Ben;
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("Дата рождения не может быть в будущем.");
                birthDate = value;
            }
        }

        public int Age
        {
            get
            {
                int age = DateTime.Now.Year - BirthDate.Year;
                if (DateTime.Now.DayOfYear < BirthDate.DayOfYear)
                {
                    age--;
                }
                return age;
            }
        }

        public override string ToString()
        {
            return LastName + " " + FirstName[0] + ". " + "Пол: "+ Ben + ", " + Age + "лет";
        }

        public void Input()
        {
            Console.Write("Фамилия: ");
            LastName = Console.ReadLine();
            Console.Write("Имя: ");
            FirstName = Console.ReadLine();
            Console.Write("Дата рождения (yyyy-MM-dd): ");
            BirthDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Пол (M/F): ");
            Ben = char.ToUpper(Console.ReadKey().KeyChar);
        }

        public void Output()
        {
            Console.WriteLine(this);
        }
    }
}
