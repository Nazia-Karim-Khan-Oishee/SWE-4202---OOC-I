using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Task1
{
    internal class Cone:Shape
    {
        public double radius,height;

        public Cone(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }
        public double SurfaceArea(double radius, double height)
        {
            return surface_area = 3.14*radius*(radius + Math.Sqrt(height*height + radius*radius));  
        }
        public double Volume(double radius, double height)
        {
            return volume = (1/3) * 3.14 * radius * radius * height;
            //return volume = ;
        }
        public override void whoAmI()
        {
            Console.WriteLine("I am a Cone.I am a three-dimensional shape." + "\n");
        }
    }
}
