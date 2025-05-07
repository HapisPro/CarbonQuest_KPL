using CarbonQuest.Main.Models;

namespace CarbonQuest.Main.Menus
{
    public static class CalculatorMenu
    {
        public static void Show(CLIStateMachine stateMachine)
        {
            Console.Clear();
            Console.WriteLine("========== Kalkulator ==========");

            var questions = APIClient.GetCalculatorQuestionsAsync().Result;
            var answers = new List<string>();

            foreach (var question in questions)
            {
                Console.WriteLine(question.Question);

                for (int i = 0; i < question.Choices.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {question.Choices[i].Answer}");
                }

                Console.Write("> ");
                var jawaban = Console.ReadLine();
                answers.Add(jawaban);
            }

            APIClient.SubmitCalculatorAnswersAsync(answers).Wait();

            Console.WriteLine("Skor berhasil disimpan! Tekan enter untuk kembali.");
            Console.ReadKey();

            stateMachine.ActivateTrigger(CLITrigger.BackToHome);
        }
    }
}
