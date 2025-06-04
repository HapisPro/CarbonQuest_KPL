using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CarbonQuest.GUI.Models;
using CarbonQuest.Lib.Utils;

using MainArticle = CarbonQuest.GUI.Models.Article;
using System.Net.Http.Json;

namespace CarbonQuest.GUI.Controllers
{
    public static class APIClient
    {
        private static readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7013/api/")
        };

        // ------------------- LOGIN ---------------------

        public static async Task<bool> LoginAsync(string username, string password)
        {
            var payload = new { username, password };
            var response = await client.PostAsJsonAsync("Login/login", payload);
            return response.IsSuccessStatusCode;
        }

        public static async Task<bool> SignupAsync(string username, string password)
        {
            var payload = new { username, password };
            var response = await client.PostAsJsonAsync("Login/register", payload);
            return response.IsSuccessStatusCode;
        }

        public static async Task LogoutAsync()
        {
            await client.PostAsync("Login/logout", null);
        }

        // ------------------- ARTICLE ---------------------

        public static async Task<List<MainArticle>> GetArticlesAsync()
        {
            var response = await client.GetAsync("Article");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonHelper.Instance.FromJson<List<MainArticle>>(json);
            }

            return new List<MainArticle>();
        }

        public static async Task<bool> AddArticleAsync(MainArticle article)
        {
            var response = await client.PostAsJsonAsync("Article", article);
            return response.IsSuccessStatusCode;
        }

        public static async Task<MainArticle> GetArticleByIdAsync(string idArticle)
        {
            var response = await client.GetAsync($"Article/{idArticle}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonHelper.Instance.FromJson<MainArticle>(json);
            }

            return null;
        }

        public static async Task<bool> EditArticleAsync(string idArticle, MainArticle article)
        {
            var response = await client.PutAsJsonAsync($"Article/{idArticle}", article);
            return response.IsSuccessStatusCode;
        }

        public static async Task<bool> DeleteArticleAsync(string idArticle)
        {
            var response = await client.DeleteAsync($"Article/{idArticle}");
            return response.IsSuccessStatusCode;
        }

        // ------------------- CALCULATOR ---------------------

        public static async Task<List<CarbonQuestion>> GetCalculatorQuestionsAsync()
        {
            var response = await client.GetAsync("Calculator/questions");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonHelper.Instance.FromJson<List<CarbonQuestion>>(json);
            }

            return new List<CarbonQuestion>();
        }


        public static async Task<bool> SubmitCalculatorAnswersAsync(List<string> answers)
        {
            var response = await client.PostAsJsonAsync("Calculator/submit", answers);
            return response.IsSuccessStatusCode;
        }

        // ------------------- LEADERBOARD ---------------------

        public static async Task<List<LeaderboardEntry>> GetLeaderboardAsync()
        {
            var response = await client.GetAsync("Leaderboard");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonHelper.Instance.FromJson<List<LeaderboardEntry>>(json);
            }

            return new List<LeaderboardEntry>();
        }
    }
}
