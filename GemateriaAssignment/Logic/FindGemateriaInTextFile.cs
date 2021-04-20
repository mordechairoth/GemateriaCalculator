using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using GemateriaAssignment.Calculator;

namespace GemateriaAssignment.FindMatches
{
    public class FindGemateriaMatches
    {
        /// <summary>
        /// Returns all instances of consecutive numbers that add up to <paramref name="sum"/>
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public Dictionary<int, int> GetAllSums(IEnumerable<int> numbers, int sum)
        {
            Dictionary<int, int> indexCount = new Dictionary<int, int>();
            List<int> cachedNumbers = new List<int>();
            int cachedNumbersSum = 0;
            int startIndex = 0;
            int finishIndex = -1;

            foreach (var number in numbers)
            {
                cachedNumbers.Add(number);
                cachedNumbersSum += number;
                finishIndex++;
               
                if (cachedNumbersSum > sum)
                {
                    int cachedNumbersCount = cachedNumbers.Count;
                    for (var i = 0; i < cachedNumbersCount; i++)
                    {
                        cachedNumbersSum -= cachedNumbers[0];
                        cachedNumbers.RemoveAt(0);
                        startIndex++;

                        if (cachedNumbersSum <= sum)
                            break;
                    }
                }

                if (cachedNumbersSum == sum)
                {
                    indexCount.Add(startIndex, cachedNumbers.Count);
                    cachedNumbersSum -= cachedNumbers[0];
                    cachedNumbers.RemoveAt(0);
                    startIndex++;
                }
            }
            
            return indexCount;
        }

        /// <summary>
        /// Gets all instances of hebrew words in a file,that their numerical values add up to the sum
        /// </summary>
        /// <param name="folderPath">Path to a folder that contains 2 files, one should be names hebrew.txt, 
        /// the other one should be named numbers.txt. The hebrew.txt file should contain only hebrew words, the numbers.txt should contain only numbers 
        /// that represent the numerical value of the hebrew words in hebrew.txt.
        /// The numbers should be in the same order as the words in the hebrew.txt file, separated with a space for each word
        /// Ex: hebrew.txt contains the phrase "ואני את אותו" the numbers.txt should contain "67 401 413" which is the numerical equivelent to the phrase in
        /// the hebrew file</param>
        /// <param name="sum">The number to calculate</param>
        /// <returns>Collection of strings where each string has the same numerical value as the <paramref name="sum"/></returns>
        public IEnumerable<string> GetAllInstancesOfGemateriaInFile(string folderPath, int sum)
        {
            string numberFile = File.ReadAllText(folderPath + "\\numbers.txt");
            Dictionary<int, int> indexCount = GetGemateriaPositionsInText(numberFile, sum);
            string hebrewTextFile = File.ReadAllText(folderPath + "\\hebrew.txt");

            return GetTextFromDict(hebrewTextFile, indexCount);
        }

        public IEnumerable<string> GetTextFromDict(string hebrewText, Dictionary<int, int> indexCount)
        {
            string[] splitString = hebrewText.Split(new[]{' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> result = new List<string>();

            foreach (var pair in indexCount)
            {
                string match = string.Join(' ', splitString, pair.Key, pair.Value );
                result.Add(match);
            }

            return result;
        }

        public Dictionary<int, int> GetGemateriaPositionsInText(string numbersAsText, int sum)
        {
            IEnumerable<int> numbers = numbersAsText.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x));
            return GetAllSums(numbers, sum);
        }

        public string ConvertHebrewTextToNumericValue(string hebrewText)
        {
            var gemateriaCalc = new GemateriaCalculator();
            hebrewText = hebrewText.Replace("\n", " ");
            var words = hebrewText.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            List<int> wordsAsNumbers = new List<int>();
            string numbersAsText = "";
            foreach (var word in words)
            {
                wordsAsNumbers.Add((int)gemateriaCalc.CalculateGemateria(word));
            }

            foreach (var number in wordsAsNumbers)
            {
                numbersAsText += number + " ";
            }
            numbersAsText = numbersAsText.Remove(numbersAsText.Length - 1);
            return numbersAsText;
        }

        public void CreateGemateriaFileFromHebrewTextFile(string folderPath)
        {
            string hebrewText = File.ReadAllText(folderPath + "\\hebrew.txt");
            string textAsGemateriaNumbers = ConvertHebrewTextToNumericValue(hebrewText);
            File.WriteAllText(folderPath + "\\numbers.txt", textAsGemateriaNumbers);
        }

    }
}