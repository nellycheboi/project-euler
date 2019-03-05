using System;
using Xunit;
using FluentAssertions;
namespace Problems.Tests
{
    public class UtilsTest
    {
        /// <summary>
        /// The palindromic sentences were  collected by Ralph Griswold. 
        /// https://www2.cs.arizona.edu/icon/oddsends/palinsen.htm
        /// </summary>
        /// <param name="input"></param>
        /// <param name="result"></param>
        [Theory]
        [InlineData("data", false)]
        [InlineData("kayak", true)]
        [InlineData("ABBA", true)]
        [InlineData("racecar", true)]
        [InlineData("a", true)]
        [InlineData("Sore was I ere I saw Eros", true)]
        [InlineData("No, it can assess an action.", true)]
        [InlineData("Bob: 'Did Anna peep?' Anna: 'Did Bob?'", true)]
        [InlineData("Sex at noon taxes.", true)]
        [InlineData("'Stop!' nine myriad murmur. 'Put up rum, rum, dairymen, in pots.'", true)]
        [InlineData("Go hang a salami, I'm a lasagna hog.", true)]
        [InlineData("Do Good's deeds live on? No, Evil's deeds do, O God.", true)]
        [InlineData("Dog, as a devil deified, lived as a god.", true)]
        [InlineData("Not so, Boston.", true)]
        [InlineData("Gate-man sees name, garage-man sees name-tag.", true)]
        [InlineData("A man, a plan, a canal -- Panama", true)]
        [InlineData("Never a foot too far, even.'", true)]
        [InlineData("Red Roses run no risk, sir, on nurses order.", true)]
        [InlineData("Too hot to hoot.", true)]
        [InlineData("I told Edna how to get a mate: 'Go two - handed.' Loti.", true)]
        [InlineData("Wonders in Italy, Latin is 'Red' now.", true)]
        [InlineData("Solo gigolos.", true)]
        [InlineData("Lay a wallaby baby ball away, Al.", true)]
        public void ShouldDeterminePalindrome(string input, bool result)
        {
            bool isPalindrome = Utils.IsPalindrome(input);

            isPalindrome
                .Should()
                .Be(result);
        }
    }
}
