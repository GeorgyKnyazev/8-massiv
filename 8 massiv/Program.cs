using System;

namespace _8_massiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sourseArray = { 1, 2, 3, 4};
            int userInput;
            int numberOfShits;
            int tempNumber;

            Console.WriteLine("Введите на какое количество позитций сдвинуть массив.");
            userInput = Convert.ToInt32(Console.ReadLine());
            numberOfShits =  userInput % sourseArray.Length;

            for (int i = 0; i < numberOfShits; i++)
            {
                for (int j = 0; j < sourseArray.Length - 1; j++)
                {
                    if(sourseArray[j] == sourseArray.Length - 1)
                    {
                        tempNumber = sourseArray[sourseArray.Length - 1];
                        sourseArray[sourseArray.Length - 1] = sourseArray[j];
                        sourseArray[j] = tempNumber;
                    }
                    else
                    {
                        tempNumber = sourseArray[j];
                        sourseArray[j] = sourseArray[j + 1];
                        sourseArray[j + 1] = tempNumber;
                    }
                }
            }

            for (int i = 0; i < sourseArray.Length; i++)
            {
                Console.Write(sourseArray[i] + " ");
            }
        }
    }
}
