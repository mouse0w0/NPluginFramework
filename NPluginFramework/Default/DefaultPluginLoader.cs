using System;
using System.Reflection;
using NPluginFramework.Exception;

namespace NPluginFramework
{
    public class DefaultPluginLoader : IPluginLoader
    {
        public IPluginContainer Load(string path)
        {
            var assembly = Assembly.LoadFile(path);
            foreach (var type in assembly.GetTypes())
            {
                var pluginAttribute = type.GetCustomAttribute<Plugin>();
                if (pluginAttribute == null)
                {
                    continue;
                }

                var constructor = type.GetConstructor(new Type[0]) ?? throw new PluginLoadException(String.Format(
                                      "Cannot create plugin main instance. Plugin: ({0}@{1}).", pluginAttribute.Name,
                                      pluginAttribute.Version));
                var main = constructor.Invoke(new object[0]);
                return new DefaultPluginContainer(pluginAttribute.Name, pluginAttribute.Version, assembly, main);
            }

            throw new PluginLoadException(String.Format("Cannot load plugin {0}", path));
        }
    }
}