class Settings
{
    public bool _closeProgram = true;
    public float input = 0;
    OutputWriter outputWriter = new OutputWriter();
    string settingsFile = "settings.txt";

    public void Save()
    {
        File.WriteAllLines(settingsFile, new string[]
                {
            $"closeProgram={_closeProgram}"
                });
    }

    public void Load()
    {
        if (!File.Exists(settingsFile)) return;

        foreach (string line in File.ReadAllLines(settingsFile))
        {
            if (line.StartsWith("closeProgram="))
                _closeProgram = line.Split('=')[1] == "True";
        }
    }

    public void Open()
    {
        outputWriter.WriteLine("--- Settings ---", ConsoleColor.Red);
        outputWriter.WriteLine("(Type 0 to exit settings)", ConsoleColor.Green);
        outputWriter.WriteLine("\n1 - Close prgram after sucessfull operation => " + _closeProgram);


        float.TryParse(Console.ReadLine(), out input);

        if (input == 0)
        {
            outputWriter.WriteLine("Settings saved!", ConsoleColor.Red);
            Save();
        }
        if (input == 1)
        {
            _closeProgram = !_closeProgram;
            Open();
        }




    }
}