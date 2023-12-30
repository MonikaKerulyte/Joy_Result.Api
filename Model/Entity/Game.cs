namespace Result.Api.Model.Entity
{
    public class Game
    {
        public int Id { get; set; }
        public DateTime StartDateTime { get; set; }
        public int NrOfQuestions { get; set; }
        public string ModeName { get; set; } = string.Empty;
    }
}
