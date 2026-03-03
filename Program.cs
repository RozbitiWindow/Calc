using System;
using System.Data;
using System.Net;
OutputWriter outputWriter = new OutputWriter();
Settings settings = new Settings();
settings.Load();

Console.WriteLine("Broken calc by RozbitiOkno");

while (true)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Math problem: ");
    Console.ResetColor();
    string input = Console.ReadLine() ?? "";

    if (input == "exit")
    {
        Console.WriteLine("Exiting ...");
        break;
    }
    if (input == "S" || input == "s") { settings.Open(); }


    try
    {
        var result = new DataTable().Compute(input, null);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"= {result}");
        Console.ResetColor();
    }
    catch
    {
        if (settings.input != 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ERROR: Invalid syntax!");
            Console.ResetColor();
        }


    }
    if (settings._closeProgram == true) { break; }
    else { continue; }
}
