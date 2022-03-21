using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Task1
{
    internal class Cylinder:Shape
    {
       public double radius,height;
        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }
        public double SurfaceArea(double radius, double height)
        {

            return surface_area = 2*3.14*radius*(radius+height);
        }
        public double Volume(double radius, double height)
        {
            return volume = 3.14*radius*radius*height;
        }
        public override void whoAmI()
        {
            Console.WriteLine("I am a Cylinder.I am a three-dimensional shape." + "\n");
        }
    }
}
