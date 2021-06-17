namespace NameGenerator
{
    public class Generate 
    {
        public static string Name()
        {
            var firstName = FirstName();
            return $"{firstName} {LastName(firstName.Length)}";
        }
        private static string FirstName()
        {
            var letters = new Alphabet();
            var fNameLen = Randomize.FirstNameLength();
            var firstName = Randomize.RandomConsonant().ToUpper();

            while (firstName.Length != fNameLen)
            {
                if (letters.vowels.Contains(firstName[firstName.Length - 1]))
                {
                    firstName += Randomize.RandomConsonant();
                }
                else
                {
                    firstName += Randomize.RandomVowel();
                }
            }
            
            return firstName;
        }
        private static string LastName(int fNameLen)
        {
                        var letters = new Alphabet();
            int lNameLen = Randomize.LastNameLength(fNameLen);
            string lastName = Randomize.RandomConsonant().ToUpper();
            while (lastName.Length != lNameLen)
            {
                if (letters.vowels.Contains(lastName[lastName.Length - 1]))
                {
                    lastName += Randomize.RandomConsonant();
                }
                else
                {
                    lastName += Randomize.RandomVowel();
                }
            }
            return lastName;
        }
    }
}