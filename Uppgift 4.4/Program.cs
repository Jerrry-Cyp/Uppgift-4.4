using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Välj ett av följande alternativ.");
        Console.WriteLine("1. Subtrahera 2 tal.");
        Console.WriteLine("2. Dividera 2 tal.");
        Console.WriteLine("3. Avsulta programmet");

        int Val = int.Parse(Console.ReadLine());

        do
        {
            if (Val == 1)
            {
                Console.Write("Första tal: ");
                int Tal1 = int.Parse(Console.ReadLine());
                Console.Write("Andra tal: ");
                int Tal2 = int.Parse(Console.ReadLine());
                Console.WriteLine(Tal1 + "-" + Tal2 + "=" + (Tal1 - Tal2));
                break;
            }
            if (Val == 2)
            {
                Console.Write("Första tal: ");
                int Tal1 = int.Parse(Console.ReadLine());
                Console.Write("Andra tal: ");
                int Tal2 = int.Parse(Console.ReadLine());
                Console.WriteLine(Tal1 + "/" + Tal2 + "=" + (Tal1 / Tal2));
                break;
            }
            if (Val == 3) break;
            else Console.WriteLine("Invalid input!"); 
        }
        while(true);
    }
}