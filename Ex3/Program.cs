using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] someInts = { 1, 1, 2, 3, 5, 8 };
            foreach (int num in someInts)
            {
                if (num%2 != 0) {
                    Console.WriteLine(num); }
            }
           
        }
    }
}
