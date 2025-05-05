namespace CarbonQuest.Main.Menus
{
    public static class LeaderboardMenu
    {
        public static void Show(CLIStateMachine stateMachine)
        {
            Console.Clear();
            Console.WriteLine("====== Leaderboard ======");

            // TODO: Fetch leaderboard dari API

            Console.WriteLine("=========================");
            Console.ReadKey();

            stateMachine.ActivateTrigger(CLITrigger.BackToHome);
        }
    }
}
