namespace CarbonQuest.Main.Menus
{
    public static class SignupMenu
    {
        public static void Show(CLIStateMachine stateMachine)
        {
            Console.Clear();
            Console.WriteLine("=== Daftar ===");
            Console.Write("Username: ");
            var username = Console.ReadLine();
            Console.Write("Password: ");
            var password = Console.ReadLine();

            // TODO: Call API Register

            stateMachine.ActivateTrigger(CLITrigger.SignupSuccess);
        }
    }
}