using UnityExplorer.Config;

namespace UnityExplorer
{
    public interface IExplorerLoader
    {
        string ExplorerFolderDestination { get; }
        string ExplorerFolderName { get; }
        string UnhollowedModulesFolder { get; }

        ConfigHandler ConfigHandler { get; }

        Action<string> OnLogMessage { get; }
        Action<string> OnLogWarning { get; }
        Action<string> OnLogError { get; }
    }
}
