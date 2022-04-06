using System;

namespace InstagramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust
            //programm kontrollib kasutaja vanust
            //kui kasutaja on 13 aastat vana või vanem, võib ta Instagrami kasutada
            //kui kasutaja on noorem kui 13, siis ei saa

            Console.WriteLine("Palun sisesta oma vanus");
            int userAge = Convert.ToInt32(Console.ReadLine());

            if (userAge > 13)
            {
                Console.WriteLine("Age check passed");
            }
            else if (userAge < 13)
            {
                Console.WriteLine("Age check failed");
            }
            else
            {
                Console.WriteLine("Age check passed");
                }

            Console.WriteLine("Kena päeva jätku!");
        }

    }

}


