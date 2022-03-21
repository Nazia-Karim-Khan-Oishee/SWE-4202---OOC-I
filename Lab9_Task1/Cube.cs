using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Task1
{
    internal class Cube:Shape
    {
         public double length;

        public Cube(double length)
        {
            this.length = length;
        }

        public double SurfaceArea(double length)
        {

            return surface_area = 6*length * length;
        }
        public double Volume(double length)
        {
            return volume = length*length*length;
        }
        public override void whoAmI()
        {
            Console.WriteLine("I am a Cube.I am a three-dimensional shape." + "\n");
        }
    }
}
