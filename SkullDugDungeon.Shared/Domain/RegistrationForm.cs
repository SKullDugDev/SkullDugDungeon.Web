namespace SkullDugDungeon.Shared.Domain
{
    public class RegistrationForm
    {
        public string UserName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public IReadOnlyCollection<SelectedGame>? ActiveGames { get; set; }
    }
}