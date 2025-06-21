
namespace WhatsappChatStats.Models;

public class Message
{
    public User User { get; set; }
    public string Text { get; set; }
    
    public DateTime Date { get; set; }
    
    public bool Multimedia { get; set; }


    public static bool IsMultimedia(Message message)
    {
        return message.Multimedia;
    }
    public static bool IsMultimedia(string message)
    {
        message = message.ToLower();
        if (message.Contains("<Multimedia omitido>") || message.Contains("(archivo adjunto)"))
            return true;
        return false;
    }
}