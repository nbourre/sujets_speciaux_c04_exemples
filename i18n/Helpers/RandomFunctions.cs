using System;
using System.Linq;

namespace i18n.Helpers
{
    public static class RandomFunctions
    {
        private static Random random = new Random();
        public static string AlphanumericalString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
