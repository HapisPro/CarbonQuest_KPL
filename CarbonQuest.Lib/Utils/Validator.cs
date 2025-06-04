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

        public static bool ValidatePassword(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 8)
                return false;

            bool hasUpper = false;
            bool hasSymbol = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                    hasUpper = true;
                else if (!char.IsLetterOrDigit(c))
                    hasSymbol = true;
            }

            return hasUpper && hasSymbol;
        }
    }
}
