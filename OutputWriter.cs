using System.Diagnostics;

class OutputWriter
{
    public void WriteLine(object message, ConsoleColor color = ConsoleColor.White)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ResetColor();
    }
}