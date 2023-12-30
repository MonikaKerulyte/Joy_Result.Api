namespace Result.Api.Model.Dto
{
    public class SaveResultRequest
    {
        public required string AccountId { get; set; }
        public int ModeId { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public int NrOfQuestions { get; set; }
        public int NrOfCorrectAnswers { get; set; }
    }
}
