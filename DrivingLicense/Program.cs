using System;

namespace DrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm arvutab kasutaja vanust
            //kui kasutaja on noorem kui 18, siis kuvab konsool
            //age check failed
            //kui kasutaja on vanem kui 18 siis kuvab konsool
            //oled piisavalt vana, et juhilube saada
            //kui kasutaja on 18, siis programm kuvab konsoolis
            //Saad juhiluba taotleda

            Console.WriteLine("Palun sisesta oma sünniaasta");
            int yearofBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2022 - yearofBirth;

            if (userAge > 18)
            {
                Console.WriteLine("Age check passed");
            }
            else if (userAge < 18)
            {
                Console.WriteLine("Age check failed");
            }
            else
            {
                Console.WriteLine("Saad juhiluba taotluse ära saata.");
            }
            Console.WriteLine("Kena päeva jätku!");
        }
    }
}