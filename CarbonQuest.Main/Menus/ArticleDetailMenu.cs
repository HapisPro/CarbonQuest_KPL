namespace CarbonQuest.Main.Menus
{
    public static class ArticleDetailMenu
    {
        public static void Show(CLIStateMachine stateMachine)
        {
            Console.Clear();
            Console.WriteLine("=== Judul Artikel ===");
            Console.WriteLine("<tanggal>");
            Console.WriteLine("<Isi artikel>");
            Console.WriteLine("1. Edit");
            Console.WriteLine("2. Hapus");
            Console.Write("> ");
            var input = Console.ReadLine();

            if (input == "1")
                stateMachine.ActivateTrigger(CLITrigger.ArticleEditSelected);
            else if (input == "2")
                stateMachine.ActivateTrigger(CLITrigger.ArticleDeleteSelected);
        }
    }
}
