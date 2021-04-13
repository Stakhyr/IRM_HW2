using System;
using System.Collections.Generic;

namespace IRM_HW2
{
    class Program
    {

        static void Main(string[] args)
        {
            //string targetDirectory = @"C:\Users\DS\Desktop\IRM_Books";

            string targetDirectory = @"C:\Users\DS\Desktop\IRM\HW1\Books";
            string outputFilePath = @"C:\Users\DS\Desktop\IRM_Books\output\test.txt";
            FileCollectionProcessing.ProcessDirectory(targetDirectory, outputFilePath);



            Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();

           //dict.Add();
        }

        


        
    }
}
