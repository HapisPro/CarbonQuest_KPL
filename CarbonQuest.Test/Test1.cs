using CarbonQuest.Main;

namespace CarbonQuest.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestLogin() {
            var username = "Hapis";
            var password = "1998";

            var result = APIClient.LoginAsync(username, password);
            Assert.IsFalse(result.Result);
        }

        [TestMethod]
        public void TestLoginGagal()
        {
            var username = "Hapis";
            var password = "1997";

            var result = APIClient.LoginAsync(username, password);
            Assert.IsFalse(result.Result);
        }
    }
}
