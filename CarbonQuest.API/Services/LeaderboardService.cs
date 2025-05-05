using CarbonQuest.API.Models;
using CarbonQuest.API.Repositories;

namespace CarbonQuest.API.Services
{
    public class LeaderboardService
    {
        private readonly UserRepository _userRepository;

        public LeaderboardService()
        {
            _userRepository = new UserRepository();
        }

        public List<LeaderboardItem> GetLeaderboard()
        {
            var users = _userRepository.GetAll();

            var leaderboard = users
                .OrderByDescending(u => u.Score)
                .Select(u => new LeaderboardItem
                {
                    Username = u.Username,
                    Score = u.Score
                })
                .ToList();

            return leaderboard;
        }
    }

    // DTO khusus leaderboard → supaya tidak expose password + active
    public class LeaderboardItem
    {
        public string Username { get; set; }
        public int Score { get; set; }
    }
}
