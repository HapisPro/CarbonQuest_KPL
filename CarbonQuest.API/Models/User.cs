using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Text.Json.Serialization;
using CarbonQuest.Lib.Utils;

namespace CarbonQuest.API.Models
{
    public class User
    {
        [JsonPropertyName("id_user")]
        public string IdUser { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonPropertyName("score")]
        public int Score { get; set; }

        [JsonPropertyName("active")]
        public bool Active { get; set; }

        // Constructor kosong untuk deserialization
        public User() { }

        // Constructor lengkap untuk inisialisasi manual + DBC
        public User(string idUser, string username, string password, int score, bool active)
        {
            Validator.CheckStringNotEmpty(idUser, nameof(idUser));
            Validator.CheckStringNotEmpty(username, nameof(username));
            Validator.CheckStringNotEmpty(password, nameof(password));
            Debug.Assert(score >= 0, "Score tidak boleh negatif.");

            IdUser = idUser;
            Username = username;
            Password = password;
            Score = score;
            Active = active;
        }

        public void SetActive(bool activeStatus)
        {
            Active = activeStatus;
        }

        public void AddScore(int scoreToAdd)
        {
            Debug.Assert(scoreToAdd >= 0, "Score yang ditambahkan harus >= 0");
            Score += scoreToAdd;
        }
    }
}