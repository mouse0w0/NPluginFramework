namespace NPluginFramework
{
    public interface IPluginLoader
    {
        IPluginContainer Load(string path);
    }
}