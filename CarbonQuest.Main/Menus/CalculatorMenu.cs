namespace CarbonQuest.Main.Menus
{
    public static class CalculatorMenu
    {
        public static void Show(CLIStateMachine stateMachine)
        {
            Console.Clear();
            Console.WriteLine("========== Kalkulator ==========");

            // TODO: Fetch pertanyaan dari API

            Console.WriteLine("Jawab pertanyaan sesuai pilihan A/B/C.");
            Console.WriteLine("Berapa kali menggunakan kendaraan pribadi?");
            Console.Write("> ");
            var q1 = Console.ReadLine();

            Console.WriteLine("Berapa banyak sampah yang Anda hasilkan hari ini?");
            Console.Write("> ");
            var q2 = Console.ReadLine();

            Console.WriteLine("Apakah Anda menggunakan air secara hemat?");
            Console.Write("> ");
            var q3 = Console.ReadLine();

            Console.WriteLine("Apakah Anda mengonsumsi daging merah?");
            Console.Write("> ");
            var q4 = Console.ReadLine();

            // TODO: Submit ke API

            Console.WriteLine("Skor berhasil disimpan!");
            Console.ReadKey();

            stateMachine.ActivateTrigger(CLITrigger.BackToHome);
        }
    }
}
