using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_1
{
    public class Rectangle
    {
        double sideA, sideB;

        public Rectangle(double sideA, double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }
        private double CalculateArea()
        {
            return sideA * sideB;
        }
        private double CalculatePerimeter()
        {
            return (sideA + sideB) * 2;
        }
        public double Area
        {
            get
            {
                return this.CalculateArea();
            }
        }
        public double Perimeter
        {
            get
            {
                return this.CalculatePerimeter();
            }
        }
    }
}
