using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Lab1_1
{
    internal class Exersizes
    {
        public Exersizes() { }
        public void exerszie_1() // функция, выполняющая задание 1
        {
            Console.WriteLine("Types:\n");
            Console.WriteLine($"byte (max):  {byte.MaxValue}");
            Console.WriteLine($"byte (min):  {byte.MinValue}");
            Console.WriteLine($"sbyte (max):  {sbyte.MaxValue}");
            Console.WriteLine($"sbyte (min):  {sbyte.MinValue}");
            Console.WriteLine($"short (max):  {short.MaxValue}");
            Console.WriteLine($"short (min):  {short.MinValue}");
            Console.WriteLine($"ushort (max):  {ushort.MaxValue}");
            Console.WriteLine($"ushort (min):  {ushort.MinValue}");
            Console.WriteLine($"int (max):  {int.MaxValue}");
            Console.WriteLine($"int (min):  {int.MinValue}");
            Console.WriteLine($"uint (max):  {uint.MaxValue}");
            Console.WriteLine($"uint (min):  {uint.MinValue}");
            Console.WriteLine($"long (max):  {long.MaxValue}");
            Console.WriteLine($"long (min):  {long.MinValue}");
            Console.WriteLine($"ulong (max):  {ulong.MaxValue}");
            Console.WriteLine($"ulong (min):  {ulong.MinValue}");
            Console.WriteLine($"float (max):  {float.MaxValue}");
            Console.WriteLine($"float (min):  {float.MinValue}");
            Console.WriteLine($"double (max):  {double.MaxValue}");
            Console.WriteLine($"double (min):  {double.MinValue}");
            Console.WriteLine($"decimal (max):  {decimal.MaxValue}");
            Console.WriteLine($"decimal (min):  {decimal.MinValue}");
            Console.WriteLine($"char (max):  {char.MaxValue}");
            Console.WriteLine($"char (min):  {char.MinValue}");
            Console.WriteLine($"bool (max(true)):  True");
            Console.WriteLine($"bool (min(false)):  False");
        }

        public void exersize_2() // функция, выполняющая задание 2
        {
            Console.WriteLine("Enter length of side A");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter length of side B");
            double b = Convert.ToDouble(Console.ReadLine());
            Rectangle rec1 = new Rectangle(a, b);
            Console.WriteLine($"Area: {rec1.Area}; Perimeter: " +
                $"{rec1.Perimeter}");

            // tests
            Rectangle test1 = new Rectangle(5, 10);
            Rectangle test2 = new Rectangle(0, 5.3);
            Rectangle test3 = new Rectangle(4.2, 9.75);
            if (test1.Area == 5 * 10 && test1.Perimeter == (5 + 10) * 2)
            {
                if (test2.Area == 0 && test2.Perimeter == (0 + 5.3) * 2)
                {
                    if (test3.Area == 4.2 * 9.75 && test3.Perimeter ==
                        (4.2 + 9.75) * 2)
                    {
                        Console.WriteLine("Good");
                    }
                }
            }
        }
        public void exersize_3() // функция, выполнябщая задание 3
        {
            Console.WriteLine("Enter name of figure");
            string name_figure = Console.ReadLine();

            Console.WriteLine("Enter count sides");
            int console_count_sides = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter coordinates of points in right ordnung" +
                "(A, B, C...)");

            // ввод координат каждой точки многоугольника
            Console.WriteLine("Enter coord. X of point A");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter coord. Y of point A");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter coord. X of point B");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter coord. Y of point B");
            int y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter coord. X of point C");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter coord. Y of point C");
            int y3 = Convert.ToInt32(Console.ReadLine());

            Point point1 = new Point(x1, y1);
            Point point2 = new Point(x2, y2);
            Point point3 = new Point(x3, y3);

            if (console_count_sides == 3)
            {
                Figure figure1 = new Figure(name_figure, point1, point2,
                    point3);
                Console.WriteLine($": perimeter = " +
                    $"{figure1.PerimeterCalculator()}");
            }
            else if (console_count_sides >= 4)
            {
                int x4 = 0;
                int y4 = 0;
                Console.WriteLine("Enter coord. X of point D");
                x4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter coord. Y of point D");
                y4 = Convert.ToInt32(Console.ReadLine());
                Point point4 = new Point(x4, y4);
                if (console_count_sides == 4)
                {
                    Figure figure1 = new Figure(name_figure, point1, point2,
                        point3, point4);
                    Console.WriteLine($": perimeter = " +
                        $"{figure1.PerimeterCalculator()}");
                }
                else if (console_count_sides == 5)
                {
                    Console.WriteLine("Enter coord. X of point E");
                    int x5 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter coord. Y of point E");
                    int y5 = Convert.ToInt32(Console.ReadLine());
                    Point point5 = new Point(x4, y4);
                    Figure figure1 = new Figure(name_figure, point1, point2,
                        point3, point4);
                    Console.WriteLine($": perimeter = " +
                        $"{figure1.PerimeterCalculator()}");
                }
            }
            else if (console_count_sides == 5)
            {
                Console.WriteLine("Enter coord. X of point D");
                int x4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter coord. Y of point D");
                int y4 = Convert.ToInt32(Console.ReadLine());
                Point point4 = new Point(x4, y4);
                Figure figure1 = new Figure(name_figure, point1, point2,
                    point3, point4);
            }
        }
    }
}
