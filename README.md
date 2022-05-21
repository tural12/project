using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isContinue = false;

            do
            {


                int testscore = 0; ;
                Console.WriteLine("Yasiniz necedir? ");
                int yas = Convert.ToInt32(Console.ReadLine());
                if (yas >= 18)
                {

                }
                else if (yas < 18)
                {
                    Console.WriteLine("Yasiniz uygun deyil");

                    break;
                }

                
                    Console.WriteLine("Baliniz necedir? ");
                    testscore = Convert.ToInt32(Console.ReadLine());
                 if (testscore > 50)
                {
                    Console.WriteLine("Tebrikler siz qebul oldunuz. ");
                }
                else if (testscore < 50)
                {
                    Console.WriteLine("Baliniz yeterli deyil. ");
                }
                Console.WriteLine("Yeni telebe varmi? He/Yox");
                string cavab = Console.ReadLine();
                if (cavab == "He")
                {
                    isContinue = true;
                }
            } while (isContinue);


        }
    }
}
