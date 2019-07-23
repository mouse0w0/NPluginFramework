using System.Collections.Generic;

namespace NPluginFramework
{
    public interface IPluginManager
    {
        IPluginContainer LoadPlugin(string file);
        
        ICollection<IPluginContainer> GetLoadedPlugins();
        
        bool LoadedPlugin(string name);
        
        IPluginContainer GetPlugin(string name);
    }
}