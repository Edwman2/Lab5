using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Circle circle2 = new Circle(6);

            circle.GetArea();
            circle2.GetArea();

            

            Console.ReadKey();
        }
    }
    public class Circle
    {
         public double Radie { get; set; }
        
        public void GetArea()
        {
            double radie = Radie * 2 * Math.PI;
            Console.WriteLine(radie);
        }
        public Circle(double radie)
        {
            Radie = radie;
        }
    }
}
