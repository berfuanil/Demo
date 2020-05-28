using System;
using System.Collections.Generic;

namespace Demo
{
    class Program
    {

        
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Addition ad = new Addition();

            List<int> userInts = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                string userValue = Console.ReadLine();

                int userInt;

                if (int.TryParse(userValue, out userInt))
                {
                    userInts.Add(userInt);
                    
                }
            }

	    //  thıs ıs hotfıx  comment

            ad.Add(userInts);



        }
    }
}
