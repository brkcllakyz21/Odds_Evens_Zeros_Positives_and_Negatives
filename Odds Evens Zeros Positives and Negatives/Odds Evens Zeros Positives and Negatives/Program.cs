using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odds_Evens_Zeros_Positives_and_Negatives
{

    class Program
    {
        static void Main(string[] args)
        {


            int[] sayı = new int[10];
            int pozitif = 0, negatif = 0, sıfır = 0, tek = 0, çift = 0;
            for (int i = 0; i < sayı.Length; i++)
            {
                Console.WriteLine("Bir sayı giriniz");
                sayı[i] = Convert.ToInt32(Console.ReadLine());

            }


            for (int i = 0; i < sayı.Length; i++)
            {

                if (sayı[i] % 2 == 0)
                {
                    çift++;
                }

                if (sayı[i] % 2 == 1)
                {
                    tek++;
                }

                if (sayı[i] == 0)
                {
                    sıfır++;
                }

                if (sayı[i] > 0)
                {
                    pozitif++;
                }

                if (sayı[i] < 0)
                {
                    negatif++;
                }



            }

            Console.WriteLine("The number of even numbers : {0}", çift);
            Console.WriteLine("The number of odd numbers : {0}", tek);
            Console.WriteLine("The number of zeros : {0}", sıfır);
            Console.WriteLine("The number of positive numbers : {0}", pozitif);
            Console.WriteLine("The number of negative numbers : {0}", negatif);


        }
    }
}


