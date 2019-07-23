using System.Reflection;

namespace NPluginFramework
{
    public interface IPluginContainer
    {
        string GetName();

        string GetVersion();

        Assembly GetAssembly();

        object GetMain();
    }
}