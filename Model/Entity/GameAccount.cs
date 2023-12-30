namespace Result.Api.Model.Entity
{
    public class GameAccount
    {
        public int Id { get; set; }
        public required string AccountId { get; set; }
        public required string Username { get; set; }
    }
}
