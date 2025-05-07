using CarbonQuest.Main.Models;

namespace CarbonQuest.Main.Menus
{
    public static class ArticleEditMenu
    {
        public static void Show(CLIStateMachine stateMachine)
        {
            Console.Write("Masukkan ID Artikel yang akan diedit: ");
            var articleId = Console.ReadLine();

            Console.Write("Judul Baru: ");
            var judul = Console.ReadLine();
            Console.Write("Tanggal Baru: ");
            var tanggal = Console.ReadLine();
            Console.Write("Isi Baru: ");
            var isi = Console.ReadLine();

            var artikel = new Article
            {
                IdArticle = articleId,
                Title = judul,
                Date = tanggal,
                Content = isi
            };

            APIClient.EditArticleAsync(articleId, artikel).Wait();
            Console.WriteLine("Artikel berhasil diedit!");
            Console.Write("[Enter] Kembali");
            Console.ReadKey();

            stateMachine.ActivateTrigger(CLITrigger.BackToHome);
        }
    }
}
