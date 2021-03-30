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
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach(var test in fileEntries) 
            {
                Console.WriteLine(test);
            }
        }
    }
}
