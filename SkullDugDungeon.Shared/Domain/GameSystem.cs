using SkullDugDungeon.Shared.Enums;

namespace SkullDugDungeon.Shared.Domain;

public class GameSystem
{
    private static readonly string None = GameSystems.None.ToString();
    private static readonly string DungeonMaster = GameSystems.DungeonMaster.ToString();

    internal GameSystem()
    {
        Name = None;
        Alias = None;
        Code = (int)Enum.Parse<GameSystems>(Name, true);
    }

    internal GameSystem(string name)
    {
        Name = name;

        if (Name.Equals(DungeonMaster)) Name = None;

        var system = Enum.Parse<GameSystems>(Name, true);

        Alias = Name.Equals(None) ? system.ToString() : system.ToDisplayString();

        Code = (int)system;
    }

    private string Name { get; }

    public string Alias { get; }

    internal int Code { get; }
}