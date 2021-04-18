using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GemateriaAssignment.Calculator
{
    public class GemateriaCalculator
    {
        HebrewLettersMapper letterMaper;
        public GemateriaCalculator()
        {
            IsMisparKuten = false;
            WithKollel = false;
            letterMaper = new HebrewLettersMapper();
        }
        public bool IsMisparKuten { get; set; }
        public bool WithKollel { get; set; }

        public long CalculateGemateria(string hebrewPhrase)
        {
            long gemateriaResult = 0;
            int kollel = 0;
            Dictionary<char, int> letterMap = letterMaper.LetterNumberMap(IsMisparKuten ? HebrewLettersMapper.GemateriaType.MisparKuten : HebrewLettersMapper.GemateriaType.Basic);
            
            foreach (var letter in hebrewPhrase)
            {
                if (letterMap.ContainsKey(letter))
                    gemateriaResult += letterMap[letter];
            }

            if (WithKollel)
                kollel = hebrewPhrase.Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(x => x.Any(y => letterMap.ContainsKey(y))).Count();
            
            return gemateriaResult + kollel;
        }

        public void Reset()
        {
            IsMisparKuten = false;
            WithKollel = false;
        }
    }

     class HebrewLettersMapper
    {
        public enum GemateriaType
        {
            Basic,
            MisparKuten
        }
        public Dictionary<char, int> LetterNumberMap(GemateriaType type = GemateriaType.Basic)
        {
            var dict = new Dictionary<char, int>
            {
                { 'א', 1 },
                { 'ב', 2 },
                { 'ג', 3 },
                { 'ד', 4 },
                { 'ה', 5 },
                { 'ו', 6 },
                { 'ז', 7 },
                { 'ח', 8 },
                { 'ט', 9 },
                { 'י', 10 },
                { 'כ', 20 },
                { 'ל', 30 },
                { 'מ', 40 },
                { 'נ', 50 },
                { 'ס', 60 },
                { 'ע', 70 },
                { 'פ', 80 },
                { 'צ', 90 },
                { 'ק', 100 },
                { 'ר', 200 },
                { 'ש', 300 },
                { 'ת', 400 },
                { 'ך', 20 },
                { 'ם', 40 },
                { 'ן', 50 },
                { 'ף', 80 },
                { 'ץ', 90 }
            };


            if (type == GemateriaType.MisparKuten)
            {
                Dictionary<char, int> misparKutenDict = new Dictionary<char, int>();

                foreach (var pair in dict)
                {
                    if (pair.Value % 100 == 0)
                        misparKutenDict[pair.Key] = pair.Value / 100;
                    else if (pair.Value % 10 == 0)
                        misparKutenDict[pair.Key] = pair.Value / 10;
                    else
                        misparKutenDict[pair.Key] = pair.Value;
                }

                dict = misparKutenDict;
            }

            return dict;
        }
    }
}
