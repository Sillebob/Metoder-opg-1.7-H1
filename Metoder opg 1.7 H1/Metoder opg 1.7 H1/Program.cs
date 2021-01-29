using System;

namespace Metoder_opg_1._7_H1
{
    class Program
    {
        static void Main(string[] args)
        {

                     /*7.	Lav et array med plads til 9 elementer. Indsæt tallene 1-9 ved hjælp af en løkke. 
                            -	Find tallet på index plads nr. 5 vha. en løkke 
                            -	Ændr dette element så det indeholder den dobbelte værdi af den forrige */

                        
            int[] numbers = new int[9]; // laver et array med plads til 9 elementer
            IndsætTal(numbers);
            TomLinje();
            GetValue(numbers,5);
            TomLinje();
            GetDobbValue(numbers, 5);


            Console.ReadKey();//holder programmet kørende indtil brugeren trykker på en tast

        }

        //Opretter metode for tom linje
        public static void TomLinje()
        {
            Console.WriteLine();
        }

        //Opretter metode der indsætter tallene 1-9
        public static void IndsætTal(int[] numbers)
        {
            for (int i = 1; i <= numbers.Length; i++) /*indsætter vhja forløkke tallene fra 1 til 9
                                                       * derfor starter løkken ved 1 og ikke 0 og grænsen er <= 
                                                       * og ikke bare <*/
            {
                numbers[i - 1] = i;
                Console.WriteLine(numbers[i - 1]);
            }
        }
        //Opretter metode der finder værdien på index plads
        public static void GetValue(int[] numbers, int indexTal)
        {
            for (int i = 1; i <= numbers.Length; i++)
            {
                numbers[i - 1] = i;
                if (numbers[i - 1] == numbers[indexTal])
                {
                    Console.WriteLine(numbers[i - 1]);
                }
            }
        }

        //Opretter metode der ændrer værdien på index plads til det dobbelte af før
        public static void GetDobbValue(int[] numbers, int indexTal)
        {
            for (int i = 1; i <= numbers.Length; i++)
            {
                numbers[i - 1] = i;//Bliver nødt til at trække 1 fra da arrayets værdier starter ved 1 men index starter ved 0
                if (numbers[i - 1] == numbers[indexTal])
                {
                    numbers[i - 1] *= 2;
                    Console.WriteLine(numbers[i - 1]);
                }
            }
        }
    }
}
