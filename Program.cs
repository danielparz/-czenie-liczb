using System;

namespace Łączenie_liczb
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = args[0];
            string[] tab = input.Split(',');
            Console.WriteLine("Podano następujące dane wejściowe:");
            foreach(var el in tab)
                Console.Write($" {el},");
            Console.WriteLine();

            try
            {
                foreach(var num in tab)                
                    for(int i = 0; i < num.Length; i++)                    
                        if(!Char.IsDigit(num[i])) throw new Exception("Podane dane wejściowe nie zawierają tylko liczb naturalnych");                                    
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            List<uint> numTab = new List<uint>();

            foreach(var val in tab)
            {
                numTab.Add(UInt32.Parse(val));
            }

            NumberGenerator numGen = new NumberGenerator(numTab.ToArray());

            try
            {
                Console.WriteLine($"Otrzymana minimalna wartość: {numGen.GetMinVal()}");
                Console.WriteLine($"Otrzymana maksymalna wartość: {numGen.GetMaxVal()}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
