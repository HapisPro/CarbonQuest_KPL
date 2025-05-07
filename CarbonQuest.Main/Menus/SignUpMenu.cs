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

            var success = APIClient.SignupAsync(username, password).Result;

            if (success)
            {
                Console.WriteLine("Pendaftaran berhasil!");
                Console.WriteLine("Tekan tombol apa saja untuk kembali ke halaman login.");
                Console.ReadKey();
                stateMachine.ActivateTrigger(CLITrigger.BackToHome); 
            }
            else
            {
                Console.WriteLine("Pendaftaran gagal. Tekan enter untuk kembali.");
                Console.ReadKey();
                stateMachine.ActivateTrigger(CLITrigger.BackToHome);
            }
        }
    }
}
