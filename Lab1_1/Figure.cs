using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_1
{
    public class Figure
    {
        Point p1, p2, p3, p4, p5;
        int count_sides;
        public string name { get; set; }
        public Figure(string name, Point p1, Point p2, Point p3, Point p4,
            Point p5)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
            this.p5 = p5;
            count_sides = 5;
            this.name = name;
        }
        public Figure(string name, Point p1, Point p2, Point p3, Point p4) :
            this(name, p1, p2,
            p3, p4, new Point(0, 0))
        {
            count_sides = 4;
        }
        public Figure(string name, Point p1, Point p2, Point p3) :
            this(name, p1, p2, p3, new Point(0, 0), new Point(0, 0))
        {
            count_sides = 3;
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(A.coordX - B.coordX, 2) +
                Math.Pow(A.coordY - B.coordY, 2));
        }
        public double PerimeterCalculator()
        {
            double perimeter = 0;
            switch (count_sides)
            {
                case 3: perimeter = this.LengthSide(p1, p2) +
                        this.LengthSide(p2, p3) + this.LengthSide(p3, p1);
                    break;
                case 4: perimeter = this.LengthSide(p1, p2) +
                        this.LengthSide(p2, p3) + this.LengthSide(p3, p4) +
                        this.LengthSide(p4, p1);
                    break;
                case 5: perimeter = this.LengthSide(p1, p2) +
                        this.LengthSide(p2, p3) + this.LengthSide(p3, p4) +
                        this.LengthSide(p4, p5) + this.LengthSide(p5, p1);
                    break;
            }
            return perimeter;
        }
    }
}
