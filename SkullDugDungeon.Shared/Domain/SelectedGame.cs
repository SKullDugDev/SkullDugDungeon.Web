namespace SkullDugDungeon.Shared.Domain
{
    public class SelectedGame
    {
        public GameSystem GameSystem { get; private set; }

        public bool IsDungeonMaster { get; private set; }

        public int GameCode { get; private set; }

        public SelectedGame()
        {
            GameSystem = new GameSystem();
            IsDungeonMaster = false;
            GameCode = GameSystem.Code;
        }

        public SelectedGame(GameSystem gameSystem, bool isDungeonMaster)
        {
            GameSystem = gameSystem;
            IsDungeonMaster = isDungeonMaster;
            GameCode = GameSystem.Code;

            // if IsDungeonMaster, multiply the value of the game code by this amount
            if (IsDungeonMaster) GameCode |= 1 << 31;
        }
    }
}