namespace SkullDugDungeon.Shared.Enums
{
    public static class GameSystemsExtension
    {
        public static string ToDisplayString(this GameSystems gameSystems) => gameSystems switch
        {
            GameSystems.None => "None",

            // D & D
            //GameSystems.Edition1 => "1E",
            //GameSystems.Edition2 => "2E",
            //GameSystems.Edition3 => "3E",
            //GameSystems.Edition4 => "4E",
            GameSystems.Edition5 => "5E",

            // Pathfinder
            //GameSystems.Pf1 => "PF1",
            GameSystems.Pf2 => "PF2",

            // Default
            _ => string.Join(", ", Enum.GetValues<GameSystems>().Where(v => gameSystems.HasFlag(v)).Select(ToDisplayString))
        };
    }
}