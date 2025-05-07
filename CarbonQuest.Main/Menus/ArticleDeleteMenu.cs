using CarbonQuest.Main.Models;

namespace CarbonQuest.Main.Menus
{
    public static class ArticleDeleteMenu
    {
        public static void Show(CLIStateMachine stateMachine)
        {
            Console.Write("Masukkan ID Artikel yang akan dihapus: ");
            var articleId = Console.ReadLine();

            Console.Write("Yakin ingin menghapus artikel (Y/N): ");
            var input = Console.ReadLine();

            if (input?.ToUpper() == "Y")
            {
                APIClient.DeleteArticleAsync(articleId).Wait();
 
                stateMachine.ActivateTrigger(CLITrigger.ArticleDeleteConfirmed);
            }
            else
            {
                stateMachine.ActivateTrigger(CLITrigger.ArticleDeleteCanceled);
            }
        }
    }
}
