namespace CarbonQuest.Main.Menus
{
    public static class ArticleMenu
    {
        public static void Show(CLIStateMachine stateMachine)
        {
            Console.Clear();
            Console.WriteLine("===== Artikel =====");

            var articles = APIClient.GetArticlesAsync().Result;

            foreach (var article in articles)
            {
                Console.WriteLine($"{article.IdArticle}. {article.Title}");
            }

            Console.WriteLine("--------------------------");
            Console.WriteLine("1. Tambah artikel");
            Console.WriteLine("2. Edit");
            Console.WriteLine("3. Hapus");
            Console.WriteLine("4. Baca");
            Console.WriteLine("0. Kembali ke Home");
            Console.Write("> ");
            var input = Console.ReadLine();

            if (input == "1")
                stateMachine.ActivateTrigger(CLITrigger.ArticleAddSelected);
            else if (input == "2")
                stateMachine.ActivateTrigger(CLITrigger.ArticleEditSelected);
            else if (input == "3")
                stateMachine.ActivateTrigger(CLITrigger.ArticleDeleteSelected);
            else if (input == "4")
                stateMachine.ActivateTrigger(CLITrigger.ArticleDetailSelected);
            else if (input == "0")
                stateMachine.ActivateTrigger(CLITrigger.BackToHome);
        }
    }
}
