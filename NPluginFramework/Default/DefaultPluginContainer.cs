using System.Reflection;

namespace NPluginFramework
{
    public class DefaultPluginContainer : IPluginContainer
    {

        private readonly string _name;
        private readonly string _version;
        private readonly Assembly _assembly;
        private readonly object _main;

        public DefaultPluginContainer(string name, string version, Assembly assembly, object main)
        {
            _name = name;
            _version = version;
            _assembly = assembly;
            _main = main;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetVersion()
        {
            return _version;
        }

        public Assembly GetAssembly()
        {
            return _assembly;
        }

        public object GetMain()
        {
            return _main;
        }
    }
}