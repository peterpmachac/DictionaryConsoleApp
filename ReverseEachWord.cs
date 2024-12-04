using System.Text;

namespace DictionaryConsoleApp
{
    internal class ReverseEachWord
    {
        public static string ReverseWords(string inputString)
        {
            return string.Join(" ", inputString.Split(' ').Select(x => new String(x.Reverse().ToArray())));
        }

        public static string ReverseWordsCoPilot(string input)
        {
            string[] words = input.Split(' ');
            StringBuilder sb = new StringBuilder();
            foreach (string word in words)
            {
                char[] letters = word.ToCharArray();
                Array.Reverse(letters);
                sb.Append(new string(letters) + " ");
            }
            return sb.ToString().Trim();
        }

    }
}
