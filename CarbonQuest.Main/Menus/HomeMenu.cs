namespace CarbonQuest.Main.Menus
{
    public static class HomeMenu
    {
        public static void Show(CLIStateMachine stateMachine)
        {
            Console.Clear();
            Console.WriteLine("========== CarbonQuest ==========");
            Console.WriteLine("Halo, Username"); // TODO: replace user
            Console.WriteLine("1. Hitung Jejak Karbon");
            Console.WriteLine("2. Leaderboard");
            Console.WriteLine("3. Artikel");
            Console.WriteLine("9. Logout");
            Console.WriteLine("=================================");
            Console.Write("> ");
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    stateMachine.ActivateTrigger(CLITrigger.CalculatorSelected);
                    break;
                case "2":
                    stateMachine.ActivateTrigger(CLITrigger.LeaderboardSelected);
                    break;
                case "3":
                    stateMachine.ActivateTrigger(CLITrigger.ArticleSelected);
                    break;
                case "9":
                    stateMachine.ActivateTrigger(CLITrigger.Logout);
                    break;
            }
        }
    }
}
