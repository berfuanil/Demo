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

            List<float> userfloats = new List<float>();

            for (float i = 0; i < 5; i++)
            {
                string userValue = Console.ReadLine();

                float userfloat;

                if (float.TryParse(userValue, out userfloat))
                {
                    userfloats.Add(userfloat);
                    
                }
            }

	    //  thıs ıs hotfıx  comment

            ad.Add(userfloats);



        }
    }
}
