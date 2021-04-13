using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IRM_HW2
{
    class FileCollectionProcessing
    {
        public static void ProcessDirectory(string targetDirectory,string outputFile) 
        {
            Dictionary<string, List<int>> resultDictionary = new Dictionary<string, List<int>>();

            string[] fileEntries = Directory.GetFiles(targetDirectory);

            Dictionary<string, List<int>> removableStuff = new Dictionary<string, List<int>>();

            removableStuff.Add("posts", new List<int> { 0, 1, 4, 5, 6, 7, 9 });
            removableStuff.Add("canopy", new List<int> { 0, 1, 3, 4, 7, 8, 9, 10 });

            for (int i=0; i<fileEntries.Length; i++) 
            {
                var bookIteam = new BookInformation(i, fileEntries[i]);

                FileProcessing.ProcessFile(resultDictionary, bookIteam);
                if (i == fileEntries.Length - 1)
                {
                    //var res = WordsBreaking.ProcessFile(fileName, result);
                    BooleanSeach.SeachQuery(resultDictionary);
                    WriteToFile(resultDictionary, outputFile);

                    //BooleanSeach.OrQuery(removableStuff, "posts", "canopy");
                }
            }

            
        }

        public static void WriteToFile(Dictionary<string, List<int>> dictionary, string outputFile)
        {
            using (StreamWriter stream = new FileInfo(outputFile).AppendText())
            {
                foreach (var entry in dictionary)
                     stream.WriteLine("{0} {1} ", entry.Key,  string.Join(" ", entry.Value));
                   // stream.WriteLine(entry.Key);
                //foreach(var f in dictionary.Values) 
                //{
                //    stream.WriteLine(string.Join(" ", f));
                //}
            }
        }
    }
}
