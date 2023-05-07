using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HomeWork.HW;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            // Создаем первый обьект
            Console.WriteLine("---------------------");
            Console.WriteLine("Задание 1");
            Console.WriteLine("---------------------");
            Console.WriteLine("Введите данные для первой фигуры:");
            Shape shape1 = new Shape();
            shape1.Input();

            // Создаем второй обьект, с заданными данными
            Shape shape2 = new Shape("Заданная(новая) фигура", 8.0, 2.0);

            // Отображение информации для обоих объектов
            shape1.Output();
            shape2.Output();

            // Находим и отображаем ярлык фигуры с наибольшим объемом
            if (shape1.Volume() > shape2.Volume())
            {
                Console.WriteLine("Ярлык фигуры с наибольшим объемом: {0}", shape1.GetLabel());
            }
            else
            {
                Console.WriteLine("Ярлык фигуры с наибольшим объемом: {0}", shape2.GetLabel());
            }

            // Найдим и отображаем, какая фигура ближе к площади поверхности равной 100.
            if (Math.Abs(100 - shape1.SurfaceArea()) < Math.Abs(100 - shape2.SurfaceArea()))
            {
                Console.WriteLine("Площадь поверхности первой фигуры ближе к 100.");
            }
            else
            {
                Console.WriteLine("Площадь поверхности второй фигуры ближе к 100.");
            }

            // Задание 2
            // Получаем количество фигур от пользователя
            Console.WriteLine("---------------------");
            Console.WriteLine("\bЗадание 2 ");
            Console.WriteLine("---------------------");
            Console.Write("Введите количество фигур: ");
            int n = int.Parse(Console.ReadLine());

            // Создать массив фигур
            Shape[] shapes = new Shape[n];

            // Входные данные для каждой фигуры.
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите данные для фигуры {0}:", i + 1);
                shapes[i] = new Shape();
                shapes[i].Input();
            }

            // Находим фигуры с самыми длинными ярлыками
            int maxLength = 0;
            Console.WriteLine("Фигуры с самым длинным ярлыком(текстовая надпись):");
            for (int i = 0; i < n; i++)
            {
                if (shapes[i].GetLabel().Length > maxLength)
                {
                    maxLength = shapes[i].GetLabel().Length;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (shapes[i].GetLabel().Length == maxLength)
                {
                    shapes[i].Output();
                }
            }

            // Создайте новую фигуру с увеличенными размерами из последней фигуры в массиве
            Shape newShape = new Shape();
            Shape lastShape = shapes[n - 1];
            newShape.SetLabel("Новая фигура с увеличенными размерами");
            newShape.SetR1(lastShape.r1 * 2);
            newShape.SetR2(lastShape.r2 * 2);

            // Отображение информации для новой фигуры
            Console.WriteLine("Данные для новой фигуры:");
            newShape.Output();

            // Отображение площади поверхности всех фигур
            double totalSurfaceArea = 0;
            for (int i = 0; i < n; i++)
            {
                totalSurfaceArea += shapes[i].SurfaceArea();
            }
            Console.WriteLine("Общая площадь поверхности всех фигур: {0}", totalSurfaceArea);

            // Находим  фигуру с наименьшей площадью
            int minIndex = 0;
            for (int i = 1; i < n; i++)
            {
                if (shapes[i].SurfaceArea() < shapes[minIndex].SurfaceArea())
                {
                    minIndex = i;
                }
            }
            Console.WriteLine("Ярлык фигуры с наименьшей площадью: MIN ({0})", shapes[minIndex].GetLabel());

            // Подсчитываем количество фигур с площадью больше 15
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (shapes[i].SurfaceArea() > 15)
                {
                    count++;
                }
            }
            Console.WriteLine("Количество фигур с площадью больше 15: {0}", count);

            // Отображение объемов всех форм
            Console.WriteLine("Объемы всех фигур:");
            double totalVolume = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}: {1}", shapes[i].GetLabel(), shapes[i].Volume());
                totalVolume += shapes[i].Volume();
            }
            Console.WriteLine("Общий объем всех фигур: {0}", totalVolume);
        }
    }
}
