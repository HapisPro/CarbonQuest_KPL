using System.Text.Json;

namespace CarbonQuest.Lib.Utils
{
    public sealed class JsonHelper
    {
        private static readonly Lazy<JsonHelper> _instance = new Lazy<JsonHelper>(() => new JsonHelper());

        public static JsonHelper Instance => _instance.Value;

        private JsonHelper() { }

        public List<T> LoadFromFile<T>(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("File path must not be null or empty.", nameof(filePath));

            if (!File.Exists(filePath))
                return new List<T>();

            try
            {
                var json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
            }
            catch (JsonException ex)
            {
                Console.Error.WriteLine($"Deserialization error: {ex.Message}");
                return new List<T>();
            }
        }

        public void SaveToFile<T>(string filePath, List<T> data)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("File path must not be null or empty.", nameof(filePath));

            var json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public T FromJson<T>(string json)
        {
            if (string.IsNullOrWhiteSpace(json))
                throw new ArgumentException("JSON string must not be null or empty.", nameof(json));

            return JsonSerializer.Deserialize<T>(json) ?? Activator.CreateInstance<T>();
        }

        public string ToJson<T>(T data)
        {
            return JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
        }
    }
}
