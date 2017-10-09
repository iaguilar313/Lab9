using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class CIrcle
    {
        private double radius;

        public double Radius
        {
            set { radius = value; }
            get { return radius; }
        }


        public void GetCircumference()
        {
            double Circmference = (2 * radius * Math.PI);
           

            Console.WriteLine("The Circumference" + Circmference);


        }


        public void GetArea()
        {
            double area = Math.PI * (radius * radius);
           
            Console.WriteLine( "The area" + area);
        }

        

        
 
    }
}
