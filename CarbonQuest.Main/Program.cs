using CarbonQuest.Lib.MockModel;
using CarbonQuest.Lib.Utils;

class Program
{
    static void Main()
    {
        var questions = new List<MockQuestion>
        {
            new MockQuestion
            {
                Id = "q1",
                QuestionText = "Berapa kali Anda menggunakan kendaraan bermotor dalam seminggu?",
                Choices = new List<Choice>
                {
                    new Choice { Answer = "0-2 kali", Score = 10 },
                    new Choice { Answer = "3-5 kali", Score = 5 },
                    new Choice { Answer = ">5 kali", Score = 2 }
                }
            },
            new MockQuestion
            {
                Id = "q2",
                QuestionText = "Seberapa sering Anda mengonsumsi daging merah?",
                Choices = new List<Choice>
                {
                    new Choice { Answer = "Jarang", Score = 10 },
                    new Choice { Answer = "Kadang-kadang", Score = 6 },
                    new Choice { Answer = "Sering", Score = 3 }
                }
            }
        };

        var userAnswers = new List<string> { "3-5 kali", "Kadang-kadang" };
        int finalScore = ScoreHelper.CalculateScore(questions, userAnswers);

        Console.WriteLine($"Skor akhir kamu: {finalScore}");
    }
}
