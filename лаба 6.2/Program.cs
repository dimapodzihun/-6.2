using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Значення х:");
            double x=Convert.ToInt32(Console.ReadLine());
            Console.Write("Значення р:");
            double p=Convert.ToInt32(Console.ReadLine()); 
            double a = aa(p, x);
            double b = bb(p, x);
            double y = Math.Pow(a, 3) / (Math.Pow(b, 2));
            Console.WriteLine("Результат y:"+y);
        }
        static double aa(double p,double x)
        {
            double a = Math.Sqrt(Math.Abs(x));
            return a; 
        }
        static double bb(double p, double  x)
        {
            double b = Math.Sin(Math.Pow(p, 2) + Math.Pow(x, 3));
            return b;
        }
    }
}
