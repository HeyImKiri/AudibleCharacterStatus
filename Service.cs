using Dalamud.Plugin.Services;

namespace AudibleCharacterStatus
{
    internal static class Service
    {
        internal static IClientState ClientState = null!;
        internal static IFramework Framework = null!;
        internal static Configuration Config = null!;
        internal static ICondition Condition = null!;
        internal static IPluginLog PluginLog = null!;
        internal static IObjectTable ObjectTable = null!;
    }
}
