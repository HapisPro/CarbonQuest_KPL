namespace CarbonQuest.Main.Menus
{
    public static class ArticleEditMenu
    {
        public static void Show(CLIStateMachine stateMachine)
        {
            Console.Clear();
            Console.WriteLine("=== Edit Artikel ===");
            Console.Write("Judul: ");
            var judul = Console.ReadLine();
            Console.Write("Tanggal: ");
            var tanggal = Console.ReadLine();

            // TODO: Call API PUT

            Console.WriteLine("Artikel berhasil diedit!");
            Console.ReadKey();

            stateMachine.ActivateTrigger(CLITrigger.BackToHome);
        }
    }
}
