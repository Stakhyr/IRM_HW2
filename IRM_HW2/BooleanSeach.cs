using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IRM_HW2
{
    class BooleanSeach 
    {
        public static void ParseQuery() 
        {
            Console.WriteLine("Enter you query");

            var entryQuery = Console.ReadLine();
            string[] words = entryQuery.Split(' ');

            var res1 = ParseWords(words);

            var res2 = ParseSigns(words); 

            //foreach(var rf in res1) 
            //{
            //    Console.WriteLine(rf);
            //}

            //foreach (var rf in res2)
            //{
            //    Console.WriteLine(rf);
            //}
        }

        private static List<string> ParseSigns(string[] words)
        {
            List<string> resultList = new List<string>();
            for(int i = 1; i < words.Length - 1; i += 2) 
            {
                resultList.Add(words[i]);
            }

            return resultList;
        }

        private static List<string> ParseWords(string[] words)
        {
            List<string> resultList = new List<string>();
            for (int i = 0; i < words.Length - 1; i += 2)
            {
                resultList.Add(words[i]);
            }

            return resultList;
        }

        public static void SeachQuery(Dictionary<string,List<int>> wordCollection) 
        {
            var result = from words in wordCollection
                         where words.Key.Contains("cl")
                         select words;

           

            foreach (var entry in result)
                Console.WriteLine("{0} {1} ", entry.Key, string.Join(" ", entry.Value));
        }

        private static string []  TakeDictValue(Dictionary<string, List<int>> wordCollection, string word) 
        {
            string  booksIndex;

            var result = from words in wordCollection
                         where words.Key.Contains(word) 
                         select words.Value;

            booksIndex = string.Join(" ", result);

            return new[] { booksIndex };
        }


        public static void OrQuery(Dictionary<string, List<int>> wordCollection, string word1, string word2)
        {
            IEnumerable<string> res1 = TakeDictValue(wordCollection,word1);
            IEnumerable<string> res2 = TakeDictValue(wordCollection, word2);


            IEnumerable<string> auto = res1.Intersect(res2);
            Console.WriteLine("Intersection of both the lists...");

            foreach (var s in auto)
                Console.WriteLine(s);


        }



      


    }
}



//posts 0 1 4 5 6 7 9
//canopy 0 1 3 4 7 8 9 10 