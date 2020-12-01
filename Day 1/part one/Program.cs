using System;
using System.Collections.Generic;
using System.IO;

namespace part_one
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lineList = new List<int>();
            var lines = File.ReadAllLines("input.txt");
            foreach(string s in lines)
            {
                lineList.Add(Convert.ToInt32(s));
            }

            foreach(int intA in lineList)
            {
                foreach(int intB in lineList)
                {
                    if((intA + intB) == 2020)
                    {
                        PrintFlag(intA, intB);
                    }
                }
            }
        }

        static void PrintFlag(int intA, int intB)
        {
            Console.WriteLine(intA * intB);
        }

    }
}
