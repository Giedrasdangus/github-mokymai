using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] Bendradarbiai = new string[100];

            Bendradarbiai[0] ="Andrius";
            Bendradarbiai[1] ="Edvinas";
            Bendradarbiai[2]= "Justas";
            Bendradarbiai[3] = "Darius";
  
            foreach(string i in Bendradarbiai)
            {
                Console.WriteLine("bendradarbis {0}", i);
            }
        }
    }
}