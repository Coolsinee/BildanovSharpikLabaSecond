using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace BildanovSharpLabaSecond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во людей: ");
            int n = int.Parse(Console.ReadLine());

            Person[] people = new Person[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nЧеловек " + (i + 1));
                people[i] = new Person();
                people[i].Input();
            }

            Console.WriteLine("\nИнформация о человеке:");

            foreach (Person p in people)
            {
                p.Output();
            }
        }
    }
}

