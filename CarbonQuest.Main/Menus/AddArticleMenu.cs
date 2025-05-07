using CarbonQuest.Main.Models;

namespace CarbonQuest.Main.Menus
{
    public static class AddArticleMenu
    {
        public static void Show(CLIStateMachine stateMachine)
        {
            Console.WriteLine("=== Tambah Artikel Baru ===");
            Console.Write("Id: ");
            var id = Console.ReadLine();
            Console.Write("Judul: ");
            var judul = Console.ReadLine();
            Console.Write("Tanggal (yyyy-mm-dd): ");
            var tanggal = Console.ReadLine();
            Console.Write("Isi Artikel: ");
            var isi = Console.ReadLine();

            var artikel = new Article
            {
                IdArticle = id,
                Title = judul,
                Date = tanggal,
                Content = isi
            };

            APIClient.AddArticleAsync(artikel).Wait();

            Console.WriteLine("Artikel berhasil ditambahkan!");
            Console.Write("[Enter] Kembali");
            Console.ReadKey();

            stateMachine.ActivateTrigger(CLITrigger.BackToHome);
        }
    }
}
