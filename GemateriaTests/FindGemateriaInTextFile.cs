using NUnit.Framework;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using GemateriaAssignment.FindMatches;

namespace GemateriaTests
{
    class FindGemateriaInTextFileTests
    {
        FindGemateriaMathces findGemateriaInTextFile;
        [SetUp]
        public void Setup()
        {
            findGemateriaInTextFile = new FindGemateriaMathces();
        }

        [Test]
        public void Get_All_Instances_Of_Consecutive_numbers_That_Are_Equlas_To_N()
        {
            List<int> numbers = new List<int>
            {
                2,
                4,
                50,
                10,
                5,
                5,
                4,
                6,
                80,
                10,
                3,
                3,
                3,
                1,
                10,
                10
            };
            int sum = 10;
            Dictionary<int, int> indexCountDict = findGemateriaInTextFile.GetAllSums(numbers, sum);

            Dictionary<int, int> expected = new Dictionary<int, int>()
            {
                { 3,1},
                {4,2 },
                {6,2 },
                {9, 1 },
                {10, 4 },
                {14, 1 },
                {15, 1 }
            };

            bool dictsAreEqual = expected.Count == indexCountDict.Count && !expected.Except(indexCountDict).Any();

            Assert.IsTrue(dictsAreEqual);
        }
    }
}
