using System.Collections.Generic;
using System.IO;

namespace NPluginFramework
{
    public abstract class PluginManagerBase : IPluginManager
    {
        protected readonly IPluginLoader Loader;

        private readonly IDictionary<string, IPluginContainer> _loadedPlugins =
            new Dictionary<string, IPluginContainer>();

        public PluginManagerBase()
        {
            Loader = CreatePluginLoader();
        }

        protected abstract IPluginLoader CreatePluginLoader();

        public IPluginContainer LoadPlugin(string file)
        {
            if (File.Exists(file))
            {
                throw new FileNotFoundException("Plugin file not found", file);
            }

            var pluginContainer = Loader.Load(file);
            _loadedPlugins.Add(pluginContainer.GetName(), pluginContainer);
            return pluginContainer;
        }

        public ICollection<IPluginContainer> GetLoadedPlugins()
        {
            return _loadedPlugins.Values;
        }

        public bool LoadedPlugin(string name)
        {
            return _loadedPlugins.ContainsKey(name);
        }

        public IPluginContainer GetPlugin(string name)
        {
            return _loadedPlugins[name];
        }
    }
}