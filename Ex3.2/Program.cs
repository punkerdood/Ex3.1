using System;
using System.Linq;

namespace Ex3._2
{
    class Program
    {
        static void Main(string[] args)
        {
           string drs = ("I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.");
            string[] sep = drs.Split(".");
            Console.WriteLine(string.Join("\n",sep));
        }
    }
}
