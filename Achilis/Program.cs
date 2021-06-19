using System;
using System.Text;
using System.Threading;
namespace Achilis
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double x , y , coefficientOfx , coefficientOfy;

            Console.Write("Enter first number = ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter first number's Coefficient = ");
            coefficientOfx = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number = ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter seccond number's Coefficient = ");
            coefficientOfy = Convert.ToDouble(Console.ReadLine());



            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(" x = {0}\n y= {1}",x,y);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("--------------");

                Console.WriteLine();

                Console.WriteLine("Time : {0}", i);

                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("x =");
                Console.Write(x *= coefficientOfx);

                Console.Write("\t");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("y =");
                Console.WriteLine(y*=coefficientOfy);

                if (x == y)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("-----------> x = {0} = y = {1}", x, y);
                    Console.Beep(2000, 500);
                    break;
                }
               
                if (x > y)
                {
                    
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine('+');
                    break;
                }
                else if (x < y)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine('-');
                }
              
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("--------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("No Match Case Found!");
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
