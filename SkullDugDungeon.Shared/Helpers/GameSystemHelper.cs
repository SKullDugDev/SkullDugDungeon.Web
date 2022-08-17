using SkullDugDungeon.Shared.Domain;
using SkullDugDungeon.Shared.Enums;

namespace SkullDugDungeon.Shared.Helpers;

public static class GameSystemHelper
{
    private static readonly string None = GameSystems.None.ToDisplayString();

    public static List<GameSystem> GetGameSystems()
    {
        // insert breakpoint here
        return Enum.GetNames<GameSystems>().Where(name => name != None).Select(name => new GameSystem(name)).ToList();
    }
}