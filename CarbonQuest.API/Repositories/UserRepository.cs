using CarbonQuest.API.Models;
using CarbonQuest.Lib.Interfaces;
using CarbonQuest.Lib.Utils;
using System.Diagnostics;

namespace CarbonQuest.API.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private const string FilePath = "Datas/users.json";
        private List<User> _users;

        public UserRepository()
        {
            _users = JsonHelper.Instance.LoadFromFile<User>(FilePath);
            Debug.Assert(_users != null, "Users data should not be null after loading.");
        }

        public List<User> GetAll()
        {
            return _users;
        }

        public User? GetById(string id)
        {
            Validator.CheckStringNotEmpty(id, nameof(id));

            return _users.FirstOrDefault(u => u.IdUser == id);
        }

        public void Add(User user)
        {
            Validator.CheckNotNull(user, nameof(user));
            Validator.CheckStringNotEmpty(user.IdUser, nameof(user.IdUser));

            // Pastikan user dengan id tidak duplikat
            Debug.Assert(!_users.Any(u => u.IdUser == user.IdUser), "Duplicate user ID detected.");

            _users.Add(user);
        }

        public void SaveChanges()
        {
            JsonHelper.Instance.SaveToFile(FilePath, _users);

            Debug.Assert(File.Exists(FilePath), "Failed to save users data to file.");
        }
    }
}