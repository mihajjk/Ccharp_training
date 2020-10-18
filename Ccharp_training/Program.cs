using System;

namespace Ccharp_training
{
    class Program
    {
        static void printMass(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i].ToString()+"  ");

            } Console.WriteLine();
        }

        static void Main()
        {
            int[] mas = new int[] {8,4,7,1,2};

            printMass(mas);
            for (int j = 1; j < mas.Length; j++)
            {
                for (int i = 0; i < mas.Length-j; i++)
                {
                    if (mas[i] > mas[i+1])
                    {
                        int tmp = mas[i];
                        mas[i] = mas[i + 1];
                        mas[i + 1] = tmp;
                    }
                }
            }


            printMass(mas);

            Console.ReadKey();
        }
    }
}
