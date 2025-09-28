using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.SetCursorPosition(50, 15);
        Console.WriteLine(">>>> TRAFIKLYS STARTER <<<<");
        Console.WriteLine();
        Thread.Sleep(2000);

        // Kør trafiklyset i en loop
        while (true)
        {
            RødtLys();
            GultLys();
            GrøntLys();
        }
    }

    // Metode til rødt lys
    static void RødtLys()
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();

        Console.SetCursorPosition(50, 15);
        Console.WriteLine(">>>> STOP - Rødt lys! <<<<");


        Thread.Sleep(4000); // 4 sekunder
        Console.Beep(500, 200);
    }

    // Metode til gult lys
    static void GultLys()
    {
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();

        Console.SetCursorPosition(50, 15);
        Console.WriteLine(">>>> Gør Klar - Gult lys! <<<<");

        Thread.Sleep(1500); // 1,5 sekunder
        Console.Beep(500, 200);
    }

    // Metode til grønt lys
    static void GrøntLys()
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();

        Console.SetCursorPosition(50, 15);
        Console.WriteLine(">>>> Kør - Grønt lys! <<<<");

        Thread.Sleep(1000); // 1 sekunder
        Console.Beep(500, 1000);
        Thread.Sleep(4000); // 4 sekunder
        

    }
}