using System.Text.Json;

namespace CarbonQuest.Lib.Utils
{
    public static class JsonHelper
    {
        public static List<T> LoadFromFile<T>(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath)) throw new ArgumentException("File path must not be null or empty.");
            if (!File.Exists(filePath)) return new List<T>();

            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
        }

        public static void SaveToFile<T>(string filePath, List<T> data)
        {
            if (string.IsNullOrWhiteSpace(filePath)) throw new ArgumentException("File path must not be null or empty.");
            var json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public static T FromJson<T>(string json)
        {
            return JsonSerializer.Deserialize<T>(json) ?? Activator.CreateInstance<T>();
        }

        public static string ToJson<T>(T data)
        {
            return JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
        }
    }
}
