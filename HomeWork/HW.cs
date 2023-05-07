using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class HW
    {
        public class Shape
        {
            public string label;
            public double r1, r2;

            // Конструктор с параметрами
            public Shape(string label, double r1, double r2)
            {
                this.label = label;
                this.r1 = r1;
                this.r2 = r2;
            }

            // Конструктор по умолчанию
            public Shape()
            {
                this.label = "";
                this.r1 = 0;
                this.r2 = 0;
            }

            // Метод для ввода через консоль
            public void Input()
            {
                Console.Write("Введите ярлык фигуры(текстовую надпись): ");
                label = Console.ReadLine();
                Console.Write("Введите r1: ");
                r1 = double.Parse(Console.ReadLine());
                Console.Write("Введите r2: ");
                r2 = double.Parse(Console.ReadLine());
            }

            // Метод для вывода через консоль
            public void Output()
            {
                Console.WriteLine("Текстовая надпись(ярлык): {0}", label);
                Console.WriteLine("r1: {0}", r1);
                Console.WriteLine("r2: {0}", r2);
                Console.WriteLine("Площадь поверхности: {0}", SurfaceArea());
                Console.WriteLine("Объем: {0}", Volume());
                Console.WriteLine();
            }

            // Метод для расчета площади поверхности
            public double SurfaceArea()
            {
                return 2 * Math.PI * r1 * r2;
            }

            // Метод для расчета объема
            public double Volume()
            {
                return 4 * Math.PI * Math.Pow(r2, 2) * r1 / 3;
            }

            // Геттер для ярлыка
            public string GetLabel()
            {
                return label;
            }

            // Сеттер для ярлыка
            public void SetLabel(string label)
            {
                this.label = label;
            }
            // Сеттер для R1
            public void SetR1(double radius)
            {
                r1 = radius;
            }
            // Сеттер для R2
            public void SetR2(double radius)
            {
                r2 = radius;
            }
        }
    }
}
