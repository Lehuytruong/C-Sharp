using System;
using System.Threading;

namespace T1807M1.Properties.Session7
{
    public class LapAssignment7
    {
        public static void Main(string[] args)
        {
            Thread t = new Thread(run);
            t.Start("Chuc mung nam moi");

        }

        public static void run(Object mgs)

        {
            string m = (string) mgs;
            while (true)
            {
                for (int i = 10; i >= 0; i--)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(100);
                }

                Console.Write(m);
            }
        }
    }

}