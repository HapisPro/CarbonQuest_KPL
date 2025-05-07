namespace CarbonQuest.Main.Menus
{
    public static class LoginMenu
    {
        // Tambahkan variabel global untuk menyimpan username
        public static string LoggedInUsername { get; set; }

        public static void Show(CLIStateMachine stateMachine)
        {
            Console.Clear();
            Console.WriteLine("=== Masuk ===");
            Console.Write("Username: ");
            var username = Console.ReadLine();
            Console.Write("Password: ");
            var password = Console.ReadLine();

            var success = APIClient.LoginAsync(username, password).Result;

            if (success)
            {
                // Simpan username setelah login berhasil
                LoggedInUsername = username;

                Console.WriteLine("Login berhasil!");
                stateMachine.ActivateTrigger(CLITrigger.LoginSuccess);
            }
            else
            {
                Console.WriteLine("Login gagal. Tekan enter untuk kembali.");
                Console.ReadKey();
                stateMachine.ActivateTrigger(CLITrigger.BackToHome);
            }
        }
    }
}
