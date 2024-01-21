using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Core.Attributes;
using CounterStrikeSharp.API.Core.Attributes.Registration;
using CounterStrikeSharp.API.Modules.Utils;

namespace CabinZombiesPlugin;

[MinimumApiVersion(150)]
public class CabinZombiesPlugin : BasePlugin
{
    private const string Version = "1.0.0";
    
    public override string ModuleName => "Cabin Zombies Plugin";
    public override string ModuleVersion => Version;
    public override string ModuleAuthor => "Moooniz";
    public override string ModuleDescription => "A simple cabin defense zombies mode for CS2";
    
    public static readonly string LogPrefix = $"[Cabin Zombies {Version}] ";
    public static readonly string MessagePrefix = $"[{ChatColors.Green}Cabin Zombies{ChatColors.White}] ";
    
    [GameEventHandler]
    public HookResult OnRoundStart(EventRoundStart @event, GameEventInfo info)
    {
        Console.WriteLine($"{LogPrefix}OnRoundStart event fired!");
        Server.PrintToChatAll($"{MessagePrefix}OnRoundStart event fired!");

        return HookResult.Continue;
    }
}
