using System;
using System.Collections.Generic;
using System.Linq;

namespace Studio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = new string("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.");
            int i = 0;
            Dictionary<char, int> wholeList = new Dictionary<char, int>();
            Dictionary<char, int> newList = new Dictionary<char, int>();
            
            foreach(char letter in input)
            {
                wholeList.TryGetValue(letter, out i);
                wholeList[letter] = i + 1;
                    
            }
           
            foreach (KeyValuePair<char,int> stuff in wholeList)
            {
                Console.WriteLine(stuff.Key + " : " + stuff.Value);
            }
                


            
        }
    }
}
