namespace SkullDugDungeon.Shared.Enums;

[Flags]
public enum GameSystems
{
    None = 0,

    // D & D

    //Edition1 = 1 << 0,
    //Edition2 = 1 << 1,
    //Edition3 = 1 << 2,
    //Edition4 = 1 << 3,
    Edition5 = 1 << 4,

    // Pathfinder

    //Pf1 = 1 << 5,
    Pf2 = 1 << 6,

    // The last flag is reserved for denoting a DM Game
    DungeonMaster = 1 << 31
}