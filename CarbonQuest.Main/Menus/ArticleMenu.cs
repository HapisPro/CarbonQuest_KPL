namespace CarbonQuest.Main.Menus
{
    public static class ArticleMenu
    {
        public static void Show(CLIStateMachine stateMachine)
        {
            Console.Clear();
            Console.WriteLine("===== Artikel =====");

            // TODO: Fetch list artikel dari API

            Console.WriteLine("a. Tambah artikel");
            Console.Write("> ");
            var input = Console.ReadLine();

            if (input == "a")
                stateMachine.ActivateTrigger(CLITrigger.ArticleAddSelected);
            else
                stateMachine.ActivateTrigger(CLITrigger.ArticleDetailSelected);
        }
    }

}
