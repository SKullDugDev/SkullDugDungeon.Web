namespace SkullDugDungeon.Shared.Domain
{
    public class SelectedGame
    {
        public GameSystem GameSystem { get; private set; }

        public bool IsDungeonMaster { get; private set; }

        public SelectedGame()
        {
            GameSystem = new GameSystem();
            IsDungeonMaster = false;
        }

        public SelectedGame(GameSystem gameSystem, bool isDungeonMaster)
        {
            GameSystem = gameSystem;
            IsDungeonMaster = isDungeonMaster;
        }
    }
}