public class HybridLogger : ILogger
{
    private readonly string _filePath;
    public HybridLogger()
    {
        // Crear un nombre único con fecha y hora
        string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
        _filePath = $"Log_{timestamp}.txt";
    }
    public void Log(string message)
    {
        // Guardar el mensaje agregándolo al final del archivo, con salto de línea
        File.AppendAllText(_filePath, message + Environment.NewLine);
        Console.WriteLine(message);
    }
}
