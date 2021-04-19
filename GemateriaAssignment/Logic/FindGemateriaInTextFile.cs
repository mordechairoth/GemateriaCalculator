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
        /// Returns all instances of consecutive numbers that add up to a sum
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public Dictionary<int, int> GetAllSums(IEnumerable<int> numbers, int sum)
        {
            Dictionary<int, int> indexCount = new Dictionary<int, int>();

            List<int> cachedNumbers = new List<int>();
            int startIndex = 0;
            int finishIndex = -1;

            foreach (var number in numbers)
            {
                cachedNumbers.Add(number);
                finishIndex++;
               
                if (cachedNumbers.Sum() > sum)
                {
                    if (cachedNumbers.Count == 1)
                    {
                        startIndex = finishIndex + 1;
                        cachedNumbers.Clear();
                    }
                    else if (cachedNumbers.Count > 1)
                    {
                        int cachedNumbersCount = cachedNumbers.Count();
                        for (var i = 0; i < cachedNumbersCount; i++)
                        {
                            cachedNumbers.RemoveAt(0);
                            startIndex++;
                            
                            if (cachedNumbers.Sum() > sum)
                            {
                                if (cachedNumbers.Count == 1)
                                {
                                    startIndex = finishIndex + 1;
                                    cachedNumbers.Clear();
                                    break;
                                }
                                else if (cachedNumbers.Count > 1)
                                {
                                    continue;
                                }
                            }
                            
                            if (cachedNumbers.Sum() == sum)
                            {
                                indexCount.Add(startIndex, cachedNumbers.Count());
                                startIndex++;
                                if (cachedNumbers.Count == 1)
                                {
                                    cachedNumbers.Clear();
                                    break;
                                }
                                else if (cachedNumbers.Count > 1)
                                {
                                    cachedNumbers.RemoveAt(0);
                                    break;
                                }
                            }

                            if (cachedNumbers.Sum() < sum)
                            {
                                break;
                            }
                        }
                    }
                   
                }
                else if (cachedNumbers.Sum() == sum)
                {
                    indexCount.Add(startIndex, cachedNumbers.Count());
                    if (cachedNumbers.Count == 1)
                    {
                        cachedNumbers.Clear();
                        startIndex = finishIndex + 1;
                    }
                    else if (cachedNumbers.Count > 1)
                    {
                        cachedNumbers.RemoveAt(0);
                        startIndex++;
                    }
                }
            }
            
            return indexCount;
        }

        public IEnumerable<string> GetAllInctancesOfGemateriaInFile(string folderPath, int sum)
        {
            string numberFile = File.ReadAllText(folderPath + "\\numbers.txt");
            Dictionary<int, int> indexCount = GetGemateriaPositionsInText(numberFile, sum);
            string hebrewTextFile = File.ReadAllText(folderPath + "\\hebrew.txt");

            return GetTextFromDict(hebrewTextFile, indexCount);
        }

        public IEnumerable<string> GetTextFromDict(string hebrewText, Dictionary<int, int> indexCount)
        {
            string[] splitString = hebrewText.Split(new[]{' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
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