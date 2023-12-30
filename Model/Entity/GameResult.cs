namespace Result.Api.Model.Entity
{
    public class GameResult
    {
        public int Id { get; set; }
        public int GameAccountId { get; set; }
        public int NrOfCorrectAnswers { get; set; }
        public DateTime FinishDateTime { get; set; }
    }
}
