using CarbonQuest.Main.Models;

namespace CarbonQuest.Main.Menus
{
    public static class LeaderboardMenu
    {
        public static void Show(CLIStateMachine stateMachine)
        {
            Console.Clear();
            Console.WriteLine("====== Leaderboard ======");

            var leaderboard = APIClient.GetLeaderboardAsync().Result;

            if (leaderboard.Count == 0)
            {
                Console.WriteLine("Belum ada data leaderboard.");
            }
            else
            {
                int rank = 1;
                foreach (var entry in leaderboard)
                {
                    Console.WriteLine($"{rank}. {entry.Username}: {entry.Score}");
                    rank++;
                }
            }

            Console.WriteLine("=========================");
            Console.Write("[Enter] Kembali");
            Console.ReadKey();
            stateMachine.ActivateTrigger(CLITrigger.BackToHome);
        }
    }
}
