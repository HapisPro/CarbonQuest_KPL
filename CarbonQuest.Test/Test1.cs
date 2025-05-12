using CarbonQuest.Main;
using CarbonQuest.Main.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarbonQuest.Test
{
    [TestClass]
    public sealed class APIClientTests
    {
        [TestMethod]
        public async Task TestSignup_Hafizh() 
        {
            var username = "NewUser";
            var password = "NewPassword123";

            var result = APIClient.SignupAsync(username, password);
            Assert.IsTrue(result.Result, "Signup should be successful with valid credentials.");
        }

        [TestMethod]
        public void TestLogin_Bintang()
        {
            var username = "Hapis";
            var password = "1998";

            var result = APIClient.LoginAsync(username, password);
            Assert.IsTrue(result.Result);
        }

        

        [TestMethod]
        public async Task TestGetArticlesAsync_Hizkia()
        {
            var result = await APIClient.GetArticlesAsync();
            Assert.IsNotNull(result, "Articles should be fetched successfully.");
            Assert.IsTrue(result.Count > 0, "There should be at least one article.");
        }

        [TestMethod]
        public async Task TestAddArticleAsync_Syarif()
        {
            var article = new Article
            {
                IdArticle = "A9",
                Title = "Test Article",
                Date = "2025-05-19",
                Content = "This is a test article content.",
                
            };

            var result = await APIClient.AddArticleAsync(article);
            Assert.IsTrue(result, "Article should be added successfully.");
        }

        [TestMethod]
        public async Task TestGetCalculatorQuestionsAsync_Albert()
        {
            var result = await APIClient.GetCalculatorQuestionsAsync();
            Assert.IsNotNull(result, "Calculator questions should be fetched.");
            Assert.IsTrue(result.Count > 0, "There should be at least one calculator question.");
        }
    }
}
