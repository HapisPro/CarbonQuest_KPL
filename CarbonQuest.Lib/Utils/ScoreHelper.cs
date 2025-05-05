using CarbonQuest.Lib.MockModel;
using CarbonQuest.Lib.Utils;

namespace CarbonQuest.Lib.Utils
{
    public static class ScoreHelper
    {
        public static int CalculateScore(List<MockQuestion> questions, List<string> selectedAnswers)
        {
            Validator.CheckNotNull(questions, nameof(questions));
            Validator.CheckNotNull(selectedAnswers, nameof(selectedAnswers));

            if (questions.Count != selectedAnswers.Count)
                throw new ArgumentException("Jumlah jawaban tidak sesuai dengan jumlah pertanyaan.");

            int totalScore = 0;

            for (int i = 0; i < questions.Count; i++)
            {
                var question = questions[i];
                var answer = selectedAnswers[i];

                var choice = question.Choices.FirstOrDefault(c => c.Answer == answer);
                if (choice == null)
                    throw new ArgumentException($"Jawaban '{answer}' tidak ditemukan dalam pilihan untuk pertanyaan ID '{question.Id}'");

                totalScore += choice.Score;
            }

            return totalScore;
        }
    }
}
