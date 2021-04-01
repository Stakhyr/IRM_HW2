using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IRM_HW2
{
    class FileProcessing
    {
        public static Dictionary<string, List<int>> ProcessFile(Dictionary<string, List<int>> resultDictionary, 
            BookInformation bookInfo) 
        {
            string allText = File.ReadAllText(bookInfo.bookPath);

            //TakeDate(allText, ref resultDictionary, bookInfo.bookID);

            //TakeEmails(allText, ref resultDictionary, bookInfo.bookID);

            //TakeBeForms(allText, ref resultDictionary, bookInfo.bookID);

            //TakeQuotes(allText, ref resultDictionary, bookInfo.bookID);

            // parse for punctuation
            string punctuation = " “'/,.?!;:\"\r\n";
            //string punctuation = @" ,.?!;:\r\n\d";
            string[] FirstFileWords = allText.Split(punctuation.ToCharArray());

            MakeDictionary(FirstFileWords, ref resultDictionary, bookInfo.bookID);

            return resultDictionary;
        }

        private static void MakeDictionary(string[] firstFileWords, ref Dictionary<string, List<int>> resultDictionary, int bookID)
        {
            foreach (var word in firstFileWords)
            {
                if (string.IsNullOrEmpty(word))
                {
                    continue;
                }

                if (!resultDictionary.ContainsKey(word))
                    // add key and value correctly
                {
                    //resultdictionary.add(word,l);
                    resultDictionary.Add(word, new List<int> { bookID });
                }
                else if(!resultDictionary[word].Contains(bookID))
                {
                    resultDictionary[word].Add(bookID );

                }
            }
        }

        private static void TakeQuotes(string allText, ref Dictionary<string, List<int>> resultDictionary, int bookID)
        {
            throw new NotImplementedException();
        }

        private static void TakeBeForms(string allText, ref Dictionary<string, List<int>> resultDictionary, int bookID)
        {
            throw new NotImplementedException();
        }

        private static void TakeEmails(string allText, ref Dictionary<string, List<int>> resultDictionary, int bookID)
        {
            throw new NotImplementedException();
        }

        private static void TakeDate(string allText, ref Dictionary<string, List<int>> resultDictionary, int bookID)
        {
            throw new NotImplementedException();
        }
    }
}
