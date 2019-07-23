using System;

namespace NPluginFramework
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class Plugin : Attribute
    {
        public string Name { get; set; }

        public string Version { get; set; }
    }
}