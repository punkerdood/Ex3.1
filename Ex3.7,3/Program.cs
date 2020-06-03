using System;
using System.Collections.Generic;
using System.Data;

namespace Ex3._7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            
            List<int> even = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                    if(i%2 ==0)
                {
                    even.Add(i);
                   
                }

            }
            foreach (int steven in even)
            {
                sum += steven;
            }
            Console.WriteLine(sum);
        }

    }
}
        
    

