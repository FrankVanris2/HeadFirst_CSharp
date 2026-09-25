

using System.Security.Cryptography;

new MessageWriter().WriteMessage();

class MessageWriter
{
    public string Message { get; set; } = "This is a message.";

    public MessageWriter()
    {
        Console.WriteLine("Running the constructor.");
    }
    public void WriteMessage()
    {
        Console.WriteLine($"The message is: {Message}");
    }
}
