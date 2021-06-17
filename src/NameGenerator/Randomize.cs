using System;

namespace NameGenerator
{
    public class Randomize 
    {
        public static int FirstNameLength(int minLength = 2, int maxLength = 15)
        {
            return RandomInteger(minLength, maxLength);
        }
        public static int LastNameLength(int firstNameLength, int maxLength = 20)
        {
            return RandomInteger(firstNameLength, maxLength);
        }
        public static string RandomConsonant()
        {
            var letter = new Alphabet();
            return Char.ToString(letter.consonants[RandomInteger(0, letter.consonants.Count)]);
        }
        public static string RandomVowel()
        {
            var letter = new Alphabet();
            return Char.ToString(letter.vowels[RandomInteger(0, letter.vowels.Count)]);
        }
        private static int RandomInteger(int start, int end)
        {
            Random rd = new Random();
            return rd.Next(start, end);
        }
    }
}