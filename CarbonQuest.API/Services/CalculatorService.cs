using CarbonQuest.API.Models;
using CarbonQuest.API.Repositories;
using CarbonQuest.Lib.Utils;

namespace CarbonQuest.API.Services
{
    public class CalculatorService
    {
        private readonly CarbonQuestionRepository _questionRepository;
        private readonly UserRepository _userRepository;

        public CalculatorService()
        {
            _questionRepository = new CarbonQuestionRepository();
            _userRepository = new UserRepository();
        }

        public List<CarbonQuestion> GetQuestions()
        {
            return _questionRepository.GetAll();
        }

        public int CalculateAndSaveScore(List<string> userAnswers)
        {
            Validator.CheckNotNull(userAnswers, nameof(userAnswers));

            var questions = _questionRepository.GetAll();

            if (questions.Count != userAnswers.Count)
                throw new ArgumentException("Jumlah jawaban harus sesuai dengan jumlah pertanyaan.");

            int totalScore = 0;

            for (int i = 0; i < questions.Count; i++)
            {
                var question = questions[i];
                var answer = userAnswers[i];

                Validator.CheckStringNotEmpty(answer, "Answer");

                // Ignore case match (A, a → match)
                var choice = question.Choices
                    .FirstOrDefault(c => c.Answer.StartsWith(answer, StringComparison.OrdinalIgnoreCase));

                if (choice == null)
                    throw new ArgumentException($"Jawaban {answer} tidak valid untuk soal {question.Id}");

                totalScore += choice.Score;
            }

            // Tambah score ke user aktif
            var activeUser = _userRepository.GetAll().FirstOrDefault(u => u.Active);
            if (activeUser == null)
                throw new Exception("Tidak ada user yang aktif.");

            activeUser.AddScore(totalScore);
            _userRepository.SaveChanges();

            return totalScore;
        }
    }
}