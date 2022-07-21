using System.Text;

namespace L2Task1.Utils
{
    public static class Util
    {
        public static string GenerateRandomPassword(int capitalLetter, int numeral, string generalLetter, int cyrillicLetter, int numberLetters)
        {
            StringBuilder stringBuilder1 = new StringBuilder();
            StringBuilder stringBuilder2 = new StringBuilder();
            StringBuilder stringBuilder3 = new StringBuilder();
            StringBuilder stringBuilder4 = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < capitalLetter; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                stringBuilder1.Append(ch);
            }
            for (int i = 0; i < numeral; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(10 * random.NextDouble() + 48)));
                stringBuilder2.Append(ch);
            }
            for (int i = 0; i < numberLetters; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 97)));
                stringBuilder3.Append(ch);
            }
            for (int i = 0; i < cyrillicLetter; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(64 * random.NextDouble() +192)));
                stringBuilder4.Append(ch);
            }
            return stringBuilder1.ToString() + stringBuilder2.ToString() + stringBuilder3.ToString()+ stringBuilder4.ToString() + generalLetter;
        }
        public static string GenerateRandomString(int numberLetters)
        {
            StringBuilder stringBuilder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < numberLetters; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 97)));
                stringBuilder.Append(ch);
            }
            return stringBuilder.ToString();
        }
        public static string GenerateRandomEmail(int numberLetters, string generalLetter)
        {
            return GenerateRandomString(numberLetters) + generalLetter;
        }
        public static T Random<T>(this IEnumerable<T> enumerable)
        {
            var r = new Random();
            var list = enumerable as IList<T> ?? enumerable.ToList();
            return list.Count == 0 ? default(T) : list[r.Next(0, list.Count)];
        }
      
        
    }
}
