
namespace WhatsappChatStats.Models;

public struct User
{
    public string Name { get; set; }
    
    //Número total de mensajes enviados por este usuario
    public int numTotMessages { get; set; }
    
    /// <summary>
    ///   numTotTextMessages + numTotMultimediaMessages = numTotMessages
    /// </summary>
    public int numTotTextMessages { get; set; }
    public int numTotMultimediaMessages { get; set; }
    
    public DateTime firstMessage { get; set; }
    public DateTime lastMessage { get; set; }
}