using System;
namespace IRM_HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            string targetDirectory = @"C:\Users\DS\Desktop\IRM\HW1\Books";
            FileCollectionProcessing.ProcessDirectory(targetDirectory);
        }
    }
}
