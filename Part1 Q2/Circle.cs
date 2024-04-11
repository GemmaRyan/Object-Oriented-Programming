using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_Q2
{
    internal class Circle
    {
        private double _radius;
        public static double lastRadius;
        public double Radius 
        { 
            get { return this._radius; } 
            set {
                this._radius = value; 
            } 
        }
        public Circle() 
        {
            lastRadius++;
            Radius = lastRadius;
        }
        public Circle()
        {



        }
        
        public string GetCircle()
        {
            double area = Math.PI*(Math.Pow(Radius, 2));
            double
        }
        public override string ToString()
        {
            return "The radius of this circle is " + Radius;
        }

    }
}
