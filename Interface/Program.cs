
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(10);
            c1.CalculateArea();
            Console.WriteLine(c1.PrintDetails());

            Rectangle r1 = new Rectangle(10, 20);
            r1.CalculateArea();
            Console.WriteLine(r1.PrintDetails());

            Icustomer c = new Transaction();
            Console.WriteLine(c.Print());

            Iorder o=new Transaction();
            Console.WriteLine(o.Print());
        }
    }
}
