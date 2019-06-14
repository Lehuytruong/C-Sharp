using System;
using Fibonacci;
namespace Fibonacci{
    public class fibonacci
    {
        public static void FBNC()
        {
            int n;
            n = 1;
            int value1 = 1, value2 = 1, a = 0;
            int cout = n ;
            var i1 = cout << value1  << value2;
            for (int i = 1; a <= n; i++)
            {
                a = value1 + value2;
                var i2 = cout << a;
                value1 = value2;
                value2 = a;
            }
        }
    }
    public class TestCsharp
    {
        public static void ain(string[]args)
        {

            int i, n;
            double s = 0.0;

            Console.Write("\n");
            Console.Write("Tinh tong day so :\n");
            Console.Write("-------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so phan tu: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\n");
            for (i = 1; i <= n; i++)
            {
                if (i < n)
                {
                    Console.Write("1/{0} + ", i);
                }
                else {
                    Console.Write("1/{0}", i);
                }
                
                s += 1 / (float)i;
            }
            Console.Write("\n\nTong cua day {0} phan tu bang: {1} \n", n, s);            

            Console.ReadKey();
        } 
    }

}