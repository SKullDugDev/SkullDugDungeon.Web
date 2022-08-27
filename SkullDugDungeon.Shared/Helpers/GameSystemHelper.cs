using SkullDugDungeon.Shared.Domain;
using SkullDugDungeon.Shared.Enums;

namespace SkullDugDungeon.Shared.Helpers;

public static class GameSystemHelper
{
    private static readonly string None = GameSystems.None.ToString();
    private static readonly string DungeonMaster = GameSystems.DungeonMaster.ToString();

    public static IList<GameSystem> GetGameSystems()
    {
        // insert breakpoint here
        return Enum.GetNames<GameSystems>().Where(name => name != None && name != DungeonMaster).Select(name => new GameSystem(name)).ToList();
    }
}