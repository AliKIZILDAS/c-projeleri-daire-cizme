using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius;
            double thickness = 0.5;

            Console.Write("Yarıçapını giriniz: ");
            if (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
            {
                Console.WriteLine("eksi yarıçap olamaz");
                return;
            }
                Console.WriteLine();
                double rin = radius - thickness, rOut = radius + thickness;

                for (double y = radius; y >= -radius; --y)
                {
                    for (double x = -radius; x < rOut; x += 0.5)
                    {
                        double value = x * x + y * y;
                        if (value >= rin * rin && value <= rOut * rOut)
                            Console.Write("*");                        
                        else                        
                            Console.Write(" ");                        
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();

                // Çözüm-2

                for (double y1=-radius; y1 < radius; y1+=1)
                {
                    double x1=Math.Sqrt(radius*radius-y1*y1);
                   
                    for (double j = -radius; j <-x1; j+=0.5)
                    {
                        Console.Write(" ");
                    }
                    for (double k = -x1; k < x1; k+=0.5)
                    {
                        Console.Write("*");
                    }
                    for (double n = x1; n < radius; n+=0.5)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("");                   
                    
                }
        }
    }
}