using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Task1
{
    internal class Circle:Shape
    {
         public double radius;
         
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double Area(double radius)
        {

            return area = 3.14*radius*radius;
        }
        public double Perimetre(double radius)
        {
            return perimeter = 2 * 3.14*radius;
        }
        public override void whoAmI()
        {
            Console.WriteLine("I am a Circle.I am a two-dimensional shape." + "\n");
        }
    }
}
