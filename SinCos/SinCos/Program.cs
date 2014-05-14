using System;



namespace SinCos
{
    class Program
    { 
        static void Main()
        {
           double x = double.Parse(Console.ReadLine());
           double y = double.Parse(Console.ReadLine());
           double z;

           z = x + y;
           z = Math.Tan(z);
           x = Math.Sin(x);
           y = Math.Cos(y);

           Console.WriteLine();
           Console.WriteLine(x);
           Console.WriteLine(y);
           Console.WriteLine(z);
           Console.ReadKey();
        }
    }
}
