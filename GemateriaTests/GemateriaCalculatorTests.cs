using NUnit.Framework;
using GemateriaAssignment.Calculator;
using System;

namespace GemateriaTests
{
    public class Tests
    {
        string hebrewPhrase;
        string hebrewPhraseWithMoreThanOneConsecutiveSpace;
        string basicPhraseWithNonHebrewChars;
        int basic;
        int misparKuten;
        int basicWithKollel;
        int misparKutenWithKollel;

        [SetUp]
        public void Setup()
        {
            hebrewPhrase = "איךת ת";
            hebrewPhraseWithMoreThanOneConsecutiveSpace = "איךת  ת";
            basicPhraseWithNonHebrewChars = "איךת ת dfsa";
            basic = 831;
            misparKuten = 12;
            basicWithKollel = 833;
            misparKutenWithKollel = 14;
        }

        [Test]
        public void Calculate_Value_Of_Phrase_Basic()
        {

            GemateriaCalculator calc = new GemateriaCalculator();
            long calculatedValue = calc.CalculateGemateria(hebrewPhrase);
            Assert.AreEqual(basic, calculatedValue);
        }

        [Test]
        public void Calculate_Value_Of_Phrase_Mispar_Kuten()
        {
            GemateriaCalculator calc = new GemateriaCalculator()
            {
                IsMisparKuten = true
            };
            long calculatedValue = calc.CalculateGemateria(hebrewPhrase);
            Assert.AreEqual(misparKuten, calculatedValue);
        }

        [Test]
        public void Calculate_Value_Of_Phrase_Basic_With_Kollel()
        {
            GemateriaCalculator calc = new GemateriaCalculator()
            {
                WithKollel = true
            };
            long calculatedValue = calc.CalculateGemateria(hebrewPhraseWithMoreThanOneConsecutiveSpace);
            Assert.AreEqual(basicWithKollel, calculatedValue);
        }

        [Test]
        public void Calculate_Value_Of_Phrase_Mispar_Kuten_With_Kollel()
        {
            GemateriaCalculator calc = new GemateriaCalculator()
            {
                WithKollel = true,
                IsMisparKuten = true
            };
            long calculatedValue = calc.CalculateGemateria(hebrewPhraseWithMoreThanOneConsecutiveSpace);
            Assert.AreEqual(misparKutenWithKollel, calculatedValue);
        }


        [Test]
        public void Calculate_Value_Of_Phrase_With_Non_Hebrew_Chars()
        {
            GemateriaCalculator calc = new GemateriaCalculator();
            long calculatedValue = calc.CalculateGemateria(basicPhraseWithNonHebrewChars);
            Assert.AreEqual(basic, calculatedValue);
        }

        [Test]
        public void Calculate_Value_Of_Phrase_With_Non_Hebrew_Chars_With_Kollel()
        {
            GemateriaCalculator calc = new GemateriaCalculator()
            {
                WithKollel = true
            };
            long calculatedValue = calc.CalculateGemateria(basicPhraseWithNonHebrewChars);
            Assert.AreEqual(basicWithKollel, calculatedValue);
        }

        [Test]
        public void Reset_Button()
        {
            GemateriaCalculator calc = new GemateriaCalculator()
            {
                WithKollel = true,
                IsMisparKuten = true
            };

            calc.Reset();
            Assert.IsFalse(calc.WithKollel);
            Assert.IsFalse(calc.IsMisparKuten);
        }
    }
}