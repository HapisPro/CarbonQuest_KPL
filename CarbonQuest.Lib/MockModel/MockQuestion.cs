namespace CarbonQuest.Lib.MockModel
{
    public class MockQuestion
    {
        public string Id { get; set; } = string.Empty;
        public string QuestionText { get; set; } = string.Empty;
        public List<Choice> Choices { get; set; } = new();
    }

    public class Choice
    {
        public string Answer { get; set; } = string.Empty;
        public int Score { get; set; }
    }
}
