namespace CarbonQuest.Main.Menus
{
    public static class WelcomeMenu
    {
        public static void Show(CLIStateMachine stateMachine)
        {
            Console.Clear();
            Console.WriteLine("=== Selamat Datang di CarbonQuest ===");
            Console.WriteLine("1. Masuk");
            Console.WriteLine("2. Daftar");
            Console.WriteLine("3. Keluar");
            Console.Write("> ");
            var input = Console.ReadLine();

            if (input == "1")
                stateMachine.ActivateTrigger(CLITrigger.LoginSelected);
            else if (input == "2")
                stateMachine.ActivateTrigger(CLITrigger.SignupSelected);
            else if (input == "3")
            {
                Environment.Exit(0);
            }
        }
    }
}