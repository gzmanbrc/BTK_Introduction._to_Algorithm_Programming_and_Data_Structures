using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Algorithm
{
    /*
    enum Islemler // belirli değerler kümesini temsil etmek için kullanılan bir türdür
    {
        Toplama,
        Cikarma,
        Carpma,
        Bolme
    }*/
    class conditions
    {

        static void Main(string[] args)
        {
            //Conditions
         /*
            int i = 0;
            while (i<10)
            {
                Console.WriteLine("dongu");
                i++;
            }


            // sayac++ == sayac+=1


            for (int i = 0; i < length; i++)
            {

            }

            // continue -->  breaks one iteration (in the loop),
            // break--> jump out of a loop


            /*
            Islemler secim = (Islemler)1; // Casting: enum değerine dönüştürme

            switch (secim)
            {
                case Islemler.Toplama:
                    Console.WriteLine("Toplama işlemi seçildi.");
                    break;
                case Islemler.Cikarma:
                    Console.WriteLine("Çıkarma işlemi seçildi.");
                    break;
                case Islemler.Carpma:
                    Console.WriteLine("Çarpma işlemi seçildi.");
                    break;
                case Islemler.Bolme:
                    Console.WriteLine("Bölme işlemi seçildi.");
                    break;
                default:
                    Console.WriteLine("Geçersiz bir işlem seçildi.");
                    break;
            }*/

            /*

            //if - else if - else
            /*
            int sayi = Convert.ToInt32(Console.ReadLine()); //casting
            if (sayi % 2 == 0)
            {
                Console.WriteLine("its is even");
            }
            else
            {
                Console.WriteLine("its is odd");
            }
            */
            // var k = (cast)Console.ReadLine();   cast yerine int char vs


            // Array
            
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            // multidimensional arrray

            int boyut = Convert.ToInt32(Console.ReadLine());
            var r = new Random();

            int[] numbers; //definitaion
            numbers = new int[boyut];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = r.Next(1, 10);
            }





















        }
    }       
}
