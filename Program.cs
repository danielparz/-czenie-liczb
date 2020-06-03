using System;

namespace Łączenie_liczb
{
    class Program
    {
        static void Main(string[] args)
        {
            uint[] numTab = new uint[args[0]];
            Console.WriteLine("Podano następujące dane wejściowe:");
            foreach(var num in numTab)
                Console.Write($" {num},");
            Console.WriteLine();

            try
            {
                foreach(var num in numTab)                
                    for(int i = 0; i < num.Length; i++)                    
                        if(!num.IsDigit(i)) throw new Exception("Podane dane wejściowe nie zawierają tylko liczb naturalnych");                                    
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            NumberGenerator numGen = new NumberGenerator(numTab);

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
