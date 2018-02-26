using System;
using ICities;
using ColossalFramework.Plugins;

namespace ContextSkylines
{
    public class Mod : IUserMod
    {
        public string Name
        {
            get { return "This is a mod"; }
        }

        public string Description
        {
            get { return "This is a test mod"; }
        }
    }

    public class Loader : LoadingExtensionBase
    {
        public override void OnLevelLoaded(LoadMode mode)
        {
            GoogleApiHandler apiHandler = new GoogleApiHandler();
            DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, "ApiHandler construtor has been called.");
            apiHandler.SendRefreshTokenRequestRequest();
        }
    }

}
