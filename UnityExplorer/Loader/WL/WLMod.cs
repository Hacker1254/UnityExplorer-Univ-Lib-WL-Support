using UnityExplorer;
using UnityExplorer.Config;
using UnityExplorer.Loader.Standalone;
using WorldLoader.Attributes;
using WorldLoader.Mods;

namespace UnityExplorer.Loader.WL
{
    [Mod(ExplorerCore.NAME, ExplorerCore.VERSION, ExplorerCore.AUTHOR)]
    internal class WLMod : UnityMod, IExplorerLoader
    {
        private UnityMod inst;
        public string ExplorerFolderName => ExplorerCore.DEFAULT_EXPLORER_FOLDER_NAME;
        public string ExplorerFolderDestination => Directory.GetCurrentDirectory() + "\\Mods";

        public string UnhollowedModulesFolder => Path.Combine(
            Directory.GetCurrentDirectory(),
            Path.Combine("WorldLoader", "UnhollowedAsm"));

        public ConfigHandler ConfigHandler => _configHandler;
        public StandaloneConfigHandler _configHandler;

        public Action<string> OnLogMessage => (str) => inst.Log(str);
        public Action<string> OnLogWarning => (str) => inst.Log("[Warn] " +str);
        public Action<string> OnLogError => (str) => inst.Error(str);

        public override void OnInject()
        {
            inst = this;
            _configHandler = new StandaloneConfigHandler();
            ExplorerCore.Init(this);
        }
    }
}
