
namespace Tamagochi.Helpers
{
    public static class StringHelper
    {
        public static string Centered(string s, int width)
        {
            if (s.Length >= width)
                return s;

            int leftPadding = (width - s.Length) / 2;
            int rightPadding = width - s.Length - leftPadding;

            return new string(' ', leftPadding) + s + new string(' ', rightPadding);
        }
    }
}
