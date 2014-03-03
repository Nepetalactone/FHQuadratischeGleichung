using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadratischeGleichung
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("Not enough arguments to perform computation");
            }

            else
            {
                double a;
                double b;
                double c;

                if ((Double.TryParse(args[0], out a) == true) && (Double.TryParse(args[1], out b) == true) && (Double.TryParse(args[2], out c) == true))
                {

                    if (((b * b) < Double.MaxValue) && ((b*b - 4*a*c) < Double.MaxValue) && ((b*b - 4*a*c) > 0))
                    {
                        Tuple<double, double> result = quadrat(a, b, c);
                        Console.WriteLine("x1 = {0}\nx2 = {1}", result.Item1.ToString(), result.Item2.ToString());
                    } else
                    {
                        Console.WriteLine("Arguments are too big or too small to perform the computation");
                    }
                } else
                {
                    Console.WriteLine("Arguments are not numbers");
                }
                Console.ReadKey();
            }
        }

        static Tuple<double, double> quadrat(double a, double b, double c)
        {
            //x12 = (-b +|- sqrt(b^2 - 4ac))/2a
            double sqrt = Math.Sqrt((b * b) - 4 * a * c);
            double x1 = (-b + sqrt) / (2 * a);
            double x2 = (-b - sqrt) / (2 * a);

            return new Tuple<double, double>(x1, x2);
        }
    }
}
