using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace InputTracker
{
    class Program
    {
        
        static void Main()
        {
            ConsoleKeyInfo input;
            Console.TreatControlCAsInput = true;
            ConsoleKey previousKey = ConsoleKey.M;
            Time time = new();

            time.SaveTime();

            do
            {   
                input = Console.ReadKey(true);

                using (StreamWriter sw = new StreamWriter("save.txt", true))
                {
                    if (previousKey != input.Key) sw.WriteLine("");
                    if ((input.Modifiers & ConsoleModifiers.Control) != 0) sw.Write($"CTRL + ");
                    if ((input.Modifiers & ConsoleModifiers.Alt) != 0) sw.Write("ALT+ ");
                    if ((input.Modifiers & ConsoleModifiers.Shift) != 0) sw.Write("SHIFT+ ");
                    sw.Write($"{input.KeyChar} ");
                }

                previousKey = input.Key;

            } while (input.Key != ConsoleKey.Escape);

            time.SaveTime();
        }
    }
}