using System;

namespace LargeDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please Enter Size Of Array");
            int Size = Convert.ToInt32(Console.ReadLine());
            int[] Arr = new int[Size];
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.Write("enter value in index (" + i + ") :");
                Arr[i] = int.Parse(Console.ReadLine());
            }

            int max = 0;
            int n = 0;                   
            int n1 = 0;
            for (int x = 0; x < Arr.Length; x++)
            {
                for (int j = x + 1; j < Arr.Length; j++)
                {
                    if (Arr[x] == Arr[j])
                    {
                        n = j;
                    }

                    n1 = x;

                    if (n - n1 > max)
                    {
                        max = n - n1;
                    }
                }
            }
            Console.WriteLine(max - 1);
        }
    }
}
