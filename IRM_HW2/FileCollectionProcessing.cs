using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IRM_HW2
{
    class FileCollectionProcessing
    {
        public static void ProcessDirectory(string targetDirectory) 
        {
            Dictionary<int, string> BookDictionary = new Dictionary<int, string>();

            string[] fileEntries = Directory.GetFiles(targetDirectory);
           

            for(int i=0; i<fileEntries.Length; i++) 
            {
                var testc = new BookInformation(i, fileEntries[i]);
            }

            foreach (var test in BookDictionary)
            {
                Console.WriteLine($"Key {test.Key} and {test.Value} ");
            }
        }

       
    }
}
