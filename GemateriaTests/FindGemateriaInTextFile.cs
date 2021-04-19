using NUnit.Framework;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using GemateriaAssignment.FindMatches;

namespace GemateriaTests
{
    class FindGemateriaInTextFileTests
    {
        FindGemateriaMatches findGemateriaInTextFile;
        [SetUp]
        public void Setup()
        {
            findGemateriaInTextFile = new FindGemateriaMatches();
        }

        [Test]
        public void Get_All_Instances_Of_Consecutive_numbers_That_Are_Equlas_To_N()
        {
            List<int> numbers = new List<int>
            {
                10,
                315,
                10,
                654,
                14
            };
            int sum = 10;
            Dictionary<int, int> indexCountDict = findGemateriaInTextFile.GetAllSums(numbers, sum);

            Dictionary<int, int> expected = new Dictionary<int, int>()
            {
                {0, 1 },
                {2,1 }
            };

            bool dictsAreEqual = expected.Count == indexCountDict.Count && !expected.Except(indexCountDict).Any();

            Assert.IsTrue(dictsAreEqual);
        }

        [Test]
        public void Convert_All_Hebrew_Text_To_Gemateria()
        {
            string hebrewText = "אני עבדך בן\n עמתך";
            string textAsGemateria = "61 96 52 530";

            string result = findGemateriaInTextFile.ConvertHebrewTextToNumericValue(hebrewText);

            Assert.AreEqual(textAsGemateria, result);
        }

        [Test]
        public void Get_Gemateria_Matches_Info_From_Number_File_Test()
        {
            string textAsGemateria = "61 96 52 530";
            int sum = 148;
            Dictionary<int, int> expected = new Dictionary<int, int>
            {
                {1, 2 }
            };

            Dictionary<int, int> result = findGemateriaInTextFile.GetGemateriaPositionsInText(textAsGemateria, sum);

            bool dictsAreEqual = expected.Count == result.Count && !expected.Except(result).Any();

            Assert.IsTrue(dictsAreEqual);
        }

        [Test]
        public void Get_Strings_From_Text_File_Based_On_Index_Count_Test()
        {
            string hebrewText = "אני עבדך בן\n עמתך";
            Dictionary<int, int> indexCount = new Dictionary<int, int>()
            {
                {0,1 },
                {1,1 },
                {3,1 }
            };
            string[] expected = new string[] {"אני", "עבדך", "עמתך" };
            string[] result = findGemateriaInTextFile.GetTextFromDict(hebrewText, indexCount).ToArray();

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Get_All_Instances_Of_Gemteria_In_File()
        {
            string folderPath = @"C:\Users\morde\Desktop\torahText\bereishis";
            string[] expected = new string[] { "החשך ויקרא אלהים לאור יום" };
            int sum = 1029;
            string[] result = findGemateriaInTextFile.GetAllInctancesOfGemateriaInFile(folderPath, sum).ToArray();

            Assert.AreEqual(expected[0], result[0]);
        }

        [Test]
        public void Create_Number_File_From_Hebrew_Text()
        {
            string folderPath = @"C:\Users\morde\Desktop\torahText\devarim";
            findGemateriaInTextFile.CreateGemateriaFileFromHebrewTextFile(folderPath);

            Assert.IsTrue(File.Exists(folderPath + "\\numbers.txt"));
        }
    }
}
