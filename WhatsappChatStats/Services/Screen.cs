namespace WhatsappChatStats.Services;

public static class Screen
{
    /// <summary>
    /// Cambia el color del texto y del fondo
    /// </summary>
    /// <param name="color"></param>
    public static void SetTextColor(ConsoleColor color){ Console.ForegroundColor = color; }
    public static void SetBGColor(ConsoleColor color) { Console.BackgroundColor = color; }
    public static void ResetColor() { Console.ResetColor(); }
    
    public static void ClearScreen(){ Console.Clear(); }

    public static void PrintTitle(string title)
    {
        //  ----------    <- $marco
        //  |  MENU  |
        //  ----------    <- $marco
        string marco ="";
        marco += "---";
        foreach(char c in title) { marco += '-'; }
        marco += "---";
        
        Console.WriteLine(marco);
        Console.WriteLine("|  "+title+"  |");
        Console.WriteLine(marco);
    }

    public static void PrintError(string error)
    {
        SetTextColor(ConsoleColor.Red);
        PrintTitle("ERROR");
        ResetColor();
        Console.WriteLine(error);
    }

    public static void WaitTillPressRandomButton()
    {
        Console.WriteLine("Pulsa cualquier tecla para continuar...");
        Console.ReadKey(true);
    }
}