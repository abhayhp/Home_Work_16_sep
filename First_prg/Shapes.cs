using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_prg
{
    abstract public class Shapes
    {
        public abstract void Area();
    }

    public class Circle: Shapes
    {
        private double radius;
        private double result;
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override void Area()
        {
            result = 3.14 * radius * radius;
        }

        public override string ToString()
        {
            return $"Area of Circle -> {result}";  
        }

    }
    
    public class Rectangle : Shapes
    {
        private double length, breadth;
        private double area_r;

        public Rectangle(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }

        public override void Area()
        {
            area_r = length * breadth;
        }

        public override string ToString()
        {
            return $" Area of Rectangle -> {area_r}";
        }

    }
}
