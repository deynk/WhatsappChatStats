using System.ComponentModel.DataAnnotations;
using WhatsappChatStats.Models;

namespace WhatsappChatStats.Services;

public static class FileManager
{
    //Path a la carpeta Chat
    public static string ChatPath { get; set; }
    // Crea la carpeta Chat
    public static void CreateInitialDirectory()
    {
        try { Directory.CreateDirectory(ChatPath); }
        catch (UnauthorizedAccessException e) { Screen.PrintError(e.Message); }
        catch (DirectoryNotFoundException e) { Screen.PrintError(e.Message); }
        catch(Exception e){ Screen.PrintError(e.Message); }
    }

    public static int CountFilesInDirectory(string path)
    {
        DirectoryInfo dir = new DirectoryInfo(path);
        FileInfo[] files = dir.GetFiles();
        return files.Length;
    }
    public static List<FileInfo> ListFilesInDirectory(string path)
    {
        DirectoryInfo dir = new DirectoryInfo(path);
        FileInfo[] files = dir.GetFiles();
        return files.ToList();
    }

    public static void ShowListFilesInDirectory(string path)
    {
        var list = ListFilesInDirectory(path);
    }
}