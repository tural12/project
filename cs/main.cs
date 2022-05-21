using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int Startnumber;
            int endnumber;

            Console.WriteLine("Bir eded daxil edin");
            Startnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bir eded daxil edin");
            endnumber = Convert.ToInt32(Console.ReadLine());

            int result = 0;

            for (int i = 0; i <=endnumber; i=i+ 1)
            {
                result = result + i;
                
            }
            

            Console.WriteLine(+Startnumber + " bu eded ile " + endnumber + " bu eded arasindaki reqemlerin cemi: " + result.ToString());
        }
    }
}
