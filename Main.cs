using System;
using System.Collections.Generic;

namespace T1807M1.Properties.Assignment6
{
    public class main
    {
        public static void Main(string[] args)
        {
            MyGenericList<int,string> m = new MyGenericList<int, string>(01," Lan");
            MyGenericList<int,string> m1 = new MyGenericList<int, string>(02," Nguyen");
            MyGenericList<int,string> m2 = new MyGenericList<int, string>(03," Long");

            int Id = m.GetKey();
            string Name = m.GetValue();
            
            
            Console.WriteLine("ID: " + Id +"/ Name: " +Name);
            Console.ReadLine();

        }
    }
}