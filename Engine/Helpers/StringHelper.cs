namespace Engine.Helpers
{
    public static class StringHelper
    {
        public static string NormalizeString(this string str, bool isToLower = true)
        {
            var result = string.Concat((str ?? string.Empty).Trim().Where(char.IsLetterOrDigit));

            if (isToLower) return result.ToLower();

            return result.ToUpper();
        }
    }
}
