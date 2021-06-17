using System;
using Xunit;

namespace NameGenerator.Tests
{
    public class RandomizeTests
    {
        [Fact]
        public void NameLengthTest()
        {
            // arrange
            string[] fullName = Generate.Name().Split(" ");

            // act
            var correctFirstName = ((fullName[0].Length <= 15) && (fullName[0].Length >= 2)) ? true : false;
            
            // assert
            Assert.True(correctFirstName);
        }
    }
}
