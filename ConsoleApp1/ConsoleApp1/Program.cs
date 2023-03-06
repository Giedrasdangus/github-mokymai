using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<string> Bendradarbiai = new List<string>(4);

            Bendradarbiai.Add("Andrius");
            Bendradarbiai.Add("Edvinas");
            Bendradarbiai.Add( "Justas");
            Bendradarbiai.Add ("Darius");
  
            foreachfff(string i in Bendradarbiai)
            {
                Console.WriteLine("bendradarbis {0}", i);
            }
        }
    }
}