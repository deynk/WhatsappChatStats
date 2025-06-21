using WhatsappChatStats.Services;

namespace WhatsappChatStats;

class Program
{
    static void Main()
    {
        Console.Title = "Stats de chats de WhatsApp";
        //Crea la carpeta donde se meterá el Chat
        FileManager.ChatPath = Path.Combine(Environment.CurrentDirectory, "Chat");
        FileManager.CreateInitialDirectory();
    }

    static void Menu()
    {
        
    }
    
    // Muestra la lista de ficheros en un directorio
    public static void ShowListFilesInDirectory(string path)
    {
        var fileList = FileManager.ListFilesInDirectory(path);
        int numElement = 0;
        Console.WriteLine("Número de archivos: " + FileManager.CountFilesInDirectory(FileManager.ChatPath));
        var files = FileManager.ListFilesInDirectory(FileManager.ChatPath);
        foreach (var file in files)
        {
            Console.WriteLine(numElement + ". " + file.Name);
            numElement++;
        }
        Screen.WaitTillPressRandomButton();
    }
}