using SkullDugDungeon.Shared.Enums;

namespace SkullDugDungeon.Shared.Domain;

public class GameSystem
{
    private static readonly string None = GameSystems.None.ToDisplayString();

    internal GameSystem()
    {
        Name = None;
        Alias = None;
        Code = (int)Enum.Parse<GameSystems>(Name, true);
    }

    internal GameSystem(string name)
    {
        Name = name;

        var system = Enum.Parse<GameSystems>(Name, true);

        Alias = system.ToDisplayString();

        Code = (int)system;
    }

    private string Name { get; }

    private string Alias { get; }

    private int Code { get; }
}