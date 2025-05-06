using CarbonQuest.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarbonQuest.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LeaderboardController : ControllerBase
    {
        private readonly LeaderboardService _leaderboardService;

        public LeaderboardController()
        {
            _leaderboardService = new LeaderboardService();
        }

        [HttpGet]
        public IActionResult GetLeaderboard()
        {
            var leaderboard = _leaderboardService.GetLeaderboard();
            return Ok(leaderboard);
        }
    }
}