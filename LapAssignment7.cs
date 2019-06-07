using System;
using System.Threading;


namespace T1807M1.Properties.Session7
{
    public class LapAssignment7
    {
        public static void Main(string[] args)
        {
            //Thread t = new Thread(run);
            //t.Start("Chuc mung nam moi");

            Thread b = new Thread(boom);
            b.Start(1);

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

        public static void boom(Object phut)
        {
            int p = (int) phut;
            int g = 50;
            int i;
            int j;
            
            for (i = p; i >=0; i--)
            {
                for (j = g; j >=0; j--)
                {
                    if (j==0)
                    {
                        if (i==0)
                        {
                            Console.WriteLine(i+":"+j);
                            Console.WriteLine(" bum");
                            break;
                        }
                    }
                    Console.WriteLine(i+":"+j);
                    Thread.Sleep(millisecondsTimeout:1000);
                }

                g = 60;
            }
        }
    }

}
