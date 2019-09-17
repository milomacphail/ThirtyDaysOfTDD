using System;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace ThirtyDaysOfTDD.UnitTests
{
    [TestFixture]


    public class StringUtilsTest
    {
        private StringUtils _stringUtils;
        [SetUp]
        public void SetupStringUtilsTests()
        {
            _stringUtils = new StringUtils();
        }


        [Test]
        public void ShouldBeAbleToCountNumberOfLettersInSimpleSentence()
        {
            var sentenceToScan = "TDD is awesome!";
            var characterToScanFor = "e";
            var expectedResult = 2;

            int result = _stringUtils.FindNumberOfOccurences(sentenceToScan, characterToScanFor);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ShouldBeAbleToCountNumberOfLettersInAComplexSentance()
        {
            var sentenceToScan = "Once is unique, twice is a coincidence, three times is a pattern.";
            var characterToScanFor = "n";
            var expectedResult = 5;

            int result = _stringUtils.FindNumberOfOccurences(sentenceToScan, characterToScanFor);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]

        public void ShouldGetAnArgumentExceptionWhenCharacterToScanForIsLargerThanOneCharacter()
        {


            var sentenceToScan = "This test should throw and exception.";
            var characterToScanFor = "xx";

           Assert.Throws<System.ArgumentException>(() => _stringUtils.FindNumberOfOccurences(sentenceToScan, characterToScanFor));
        }

    }
}