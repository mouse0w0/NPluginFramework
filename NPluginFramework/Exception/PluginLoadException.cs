namespace NPluginFramework.Exception
{
    public class PluginLoadException : System.Exception
    {
        public PluginLoadException(string message) : base(message)
        {
        }

        public PluginLoadException(string message, System.Exception innerException) : base(message, innerException)
        {
        }
    }
}