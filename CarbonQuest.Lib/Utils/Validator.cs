namespace CarbonQuest.Lib.Utils
{
    public static class Validator
    {
        public static void CheckNotNull(object? obj, string paramName)
        {
            if (obj == null) throw new ArgumentNullException(paramName);
        }

        public static void CheckStringNotEmpty(string? str, string paramName)
        {
            if (string.IsNullOrWhiteSpace(str)) throw new ArgumentException($"{paramName} cannot be null or empty.");
        }
    }
}
