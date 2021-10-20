using System;

namespace algoritum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
if (a =! b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
                Console.Write("Най-големият общ делител е: " + a)
            }
        }
    }
}
