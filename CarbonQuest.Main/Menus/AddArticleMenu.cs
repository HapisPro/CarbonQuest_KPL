namespace CarbonQuest.Main.Menus
{
    public static class AddArticleMenu
    {
        public static void Show(CLIStateMachine stateMachine)
        {
            Console.Clear();
            Console.WriteLine("=== Tambah Artikel Baru ===");
            Console.Write("Judul: ");
            var judul = Console.ReadLine();
            Console.Write("Tanggal (yyyy-mm-dd): ");
            var tanggal = Console.ReadLine();
            Console.Write("Isi Artikel: ");
            var isi = Console.ReadLine();

            // TODO: Call API POST untuk tambah artikel

            Console.WriteLine("Artikel berhasil ditambahkan!");
            Console.ReadKey();

            stateMachine.ActivateTrigger(CLITrigger.BackToHome);
        }
    }
}
