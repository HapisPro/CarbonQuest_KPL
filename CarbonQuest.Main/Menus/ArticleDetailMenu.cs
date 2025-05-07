namespace CarbonQuest.Main.Menus
{
    public static class ArticleDetailMenu
    {
        public static void Show(CLIStateMachine stateMachine)
        {
            Console.Write("Masukkan ID Artikel: ");
            var articleId = Console.ReadLine();

            var article = APIClient.GetArticleByIdAsync(articleId).Result;

            if (article == null)
            {
                Console.WriteLine("Artikel tidak ditemukan.");
                Console.ReadKey();
                stateMachine.ActivateTrigger(CLITrigger.BackToHome);
                return;
            }

            Console.WriteLine($"=== {article.Title} ===");
            Console.WriteLine(article.Date);
            Console.WriteLine(article.Content);
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("0. Kembali");
            Console.Write("> ");
            var input = Console.ReadLine();
            
            if (input == "0")
                stateMachine.ActivateTrigger(CLITrigger.BackToHome);
        }
    }
}
