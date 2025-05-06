using CarbonQuest.API.Models;
using CarbonQuest.Lib.Interfaces;
using CarbonQuest.Lib.Utils;
using System.Diagnostics;

namespace CarbonQuest.API.Services
{
    public class UserService
    {
        private readonly IRepository<User> _userRepository;

        public UserService(IRepository<User> userRepository)
        {
            Validator.CheckNotNull(userRepository, nameof(userRepository));
            _userRepository = userRepository;
        }

        public User? Login(string username, string password)
        {
            Validator.CheckStringNotEmpty(username, nameof(username));
            Validator.CheckStringNotEmpty(password, nameof(password));

            var users = _userRepository.GetAll();
            var user = users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                // Set semua user active=false dulu
                foreach (var u in users)
                {
                    u.SetActive(false);
                }
                // User ini aktif
                user.SetActive(true);
                _userRepository.SaveChanges();
            }

            return user;
        }

        public void Register(string username, string password)
        {
            Validator.CheckStringNotEmpty(username, nameof(username));
            Validator.CheckStringNotEmpty(password, nameof(password));

            var users = _userRepository.GetAll();

            if (users.Any(u => u.Username == username))
            {
                throw new ArgumentException("Username already exists.");
            }

            var newUser = new User
            {
                IdUser = $"u{users.Count + 1}",
                Username = username,
                Password = password,
                Score = 0,
                Active = false
            };

            _userRepository.Add(newUser);
            _userRepository.SaveChanges();
        }

        public User? GetActiveUser()
        {
            return _userRepository.GetAll().FirstOrDefault(u => u.Active);
        }

        public void Logout()
        {
            var users = _userRepository.GetAll();

            foreach (var user in users)
            {
                if (user.Active)
                {
                    user.SetActive(false);
                }
            }

            _userRepository.SaveChanges();
        }

    }
}