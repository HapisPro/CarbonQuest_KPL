using CarbonQuest.Main;

namespace CarbonQuest.Main.Menus
{
    public static class ArticleDeleteMenu
    {
        public static void Show(CLIStateMachine stateMachine)
        {
            Console.Clear();
            Console.WriteLine("Yakin ingin menghapus artikel (Y/N): ");
            var input = Console.ReadLine();

            if (input?.ToUpper() == "Y")
            {
                // TODO: Call API DELETE

                stateMachine.ActivateTrigger(CLITrigger.ArticleDeleteConfirmed);
            }
            else
            {
                stateMachine.ActivateTrigger(CLITrigger.ArticleDeleteCanceled);
            }
        }
    }

}