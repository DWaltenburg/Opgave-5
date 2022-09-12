using System;

namespace Opgave_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey tast;
            do
            {
                SkrivVelkomst();
                int dinalder = ReadInt("Indtast din alder: ");
                int moralder = ReadInt("Indtast din mor's alder: ");
                Console.WriteLine($"Du er {dinalder} år gammel.");
                Console.WriteLine($"Din mor er {moralder} år gammel.");
                Console.WriteLine($"Forskellen er {moralder - dinalder} år.");
                Console.WriteLine("Tryk på en tast for at starte forfra. ESC for at afslutte...");
                tast = Console.ReadKey().Key;
            } while (tast != ConsoleKey.Escape);
        }
        static void SkrivVelkomst()
        {
            Console.Clear();
            Console.WriteLine("---------------------");
            Console.WriteLine("Velkommen til min App");
            Console.WriteLine("---------------------");
        }

        static int ReadInt(string promt)
        {
            Console.Write(promt);
            string input = Console.ReadLine();
            int value = Convert.ToInt32(input);
            return value;
        }
    }
}
