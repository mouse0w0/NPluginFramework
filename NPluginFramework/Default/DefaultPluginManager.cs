namespace NPluginFramework
{
    public class DefaultPluginManager : PluginManagerBase
    {
        protected override IPluginLoader CreatePluginLoader()
        {
            return new DefaultPluginLoader();
        }
    }
}