namespace Result.Api.Model.Dto
{
    public class ResultDto
    {
        public string? Username { get; set; }
        public string? ModeName {  get; set; }
        public int NrOfQuestions { get; set; }
        public int NrOfCorrectAnswers { get; set; }
        public DateTime? StartedDateTime { get; set; }
        public DateTime? FinishDateTime { get; set; }
    }
}
