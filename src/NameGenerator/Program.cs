using System;
using System.Collections.Generic;

namespace NameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var letters = new Alphabet();

            int fNameLen = Randomize.FirstNameLength();
            int lNameLen = Randomize.LastNameLength(fNameLen);               

            string firstName = Randomize.RandomConsonant().ToUpper();
            string lastName = Randomize.RandomConsonant().ToUpper();

            while (firstName.Length != fNameLen)
            {
                if(letters.vowels.Contains(firstName[firstName.Length-1]))
                {
                    firstName += Randomize.RandomConsonant();
                }
                else
                { 
                    firstName += Randomize.RandomVowel();
                }
            }

            while (lastName.Length != lNameLen)
            {
                if( letters.vowels.Contains(lastName[lastName.Length-1]))
                {
                    lastName += Randomize.RandomConsonant();
                }
                else
                {
                    lastName += Randomize.RandomVowel();
                }
            }
            System.Console.WriteLine($"{firstName} {lastName}");
        }
    }
}
