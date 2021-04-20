using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace GemateriaAssignment.FindMatches
{
    public class GemateriaFromTorahCalculator
    {
       
        public IEnumerable<string> GetAllGematrios(int sum)
        {
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\torah";
            bool needFilesExist = File.Exists(folderPath + "\\hebrew.txt") && File.Exists(folderPath + "\\numbers");
            
            if (!needFilesExist)
                CreateNeededFilesForCalculatingTorahGemateria(folderPath);
            
            
            FindGemateriaMatches gemateriaMatches = new FindGemateriaMatches();

            IEnumerable<string> matches = gemateriaMatches.GetAllInstancesOfGemateriaInFile(folderPath, sum);

            return matches;
            
        }

        private void CreateNeededFilesForCalculatingTorahGemateria(string folderPath)
        {
            Directory.CreateDirectory(folderPath);
            WriteResourceToFile("GemateriaAssignment.TorahText.Torah.numbers.txt", folderPath + "\\numbers.txt");
            WriteResourceToFile("GemateriaAssignment.TorahText.Torah.hebrew.txt", folderPath + "\\hebrew.txt");
        }
        private void WriteResourceToFile(string resourceName, string filePath)
        {
            using (var resource = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            {
                using (var file = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    resource.CopyTo(file);
                }
            }
        }
    }
}
