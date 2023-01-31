using System;

namespace Reverce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the statment");
            string Value = Console.ReadLine();

            string[] arr = Value.Split(' ');

            Console.Write(string.Join("*", arr));
            //for (int i = arr.Length-1; i >=0; i--)
            //{
            //    Console.Write(arr[i]+" ");
            //}

            Console.ReadLine();
        }
    }
}
