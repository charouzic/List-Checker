using System;
using System.Collections.Generic;

namespace list_checker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            List<int> numbers = new List<int>() {-6,-5,10,15};

            Processor p = new Processor();

            Console.WriteLine($"{p.listChecker(numbers)}");

        }
    }
    class Processor
    {
        public bool listChecker(List<int> numbers)
        {
            if (numbers.Count < 2)
                return true;
            for (int counter = 1; counter < numbers.Count; counter++)
            {
                if (numbers[counter - 1] > numbers[counter])
                {
                    return false;
                }
                else
                    continue;
            }
            return true;
        }
    }
}
