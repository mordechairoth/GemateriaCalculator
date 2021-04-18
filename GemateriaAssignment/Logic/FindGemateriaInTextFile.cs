using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GemateriaAssignment.FindMatches
{
    public class FindGemateriaMathces
    {
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
                    }
                    else if (cachedNumbers.Count() > 1)
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
    }
}