public class FileLogger : ILogger
{
    public void Log(string message)
    {
         File.WriteAllText("Log.txt",message);
    }
}