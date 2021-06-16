using System;
using System.Collections.Generic;

namespace NameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var letters = new Alphabet();

            Random rd = new Random();
            int rd_firstNameLen = rd.Next(2, 15);
            int rd_lastNameLen = rd.Next(3, rd_firstNameLen);           

            string firstName = Char.ToString(letters.consonants[rd.Next(0, letters.consonants.Count)]).ToUpper();
            string lastName = Char.ToString(letters.consonants[rd.Next(0, letters.consonants.Count)]).ToUpper();

            int vowelRandomIndex, consonantRandomIndex;
            while (firstName.Length != rd_firstNameLen)
            {
                if( letters.vowels.Contains(firstName[firstName.Length-1]))
                {
                    consonantRandomIndex = rd.Next(0, letters.consonants.Count);
                    firstName += letters.consonants[consonantRandomIndex];
                }
                else
                {
                    vowelRandomIndex = rd.Next(0,  letters.vowels.Count);
                    firstName +=  letters.vowels[vowelRandomIndex];
                }
            }

            while (lastName.Length != rd_lastNameLen)
            {
                if( letters.vowels.Contains(lastName[lastName.Length-1]))
                {
                    consonantRandomIndex = rd.Next(0, letters.consonants.Count);
                    lastName += letters.consonants[consonantRandomIndex];
                }
                else
                {
                    vowelRandomIndex = rd.Next(0,  letters.vowels.Count);
                    lastName +=  letters.vowels[vowelRandomIndex];
                }
            }
            System.Console.WriteLine($"{firstName} {lastName}");
        }
    }
}
