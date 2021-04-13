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

        public static void SeachQuery(Dictionary<string,List<int>> wordCollection,string word) 
        {
            List<int> valueList = new List<int>();
            var result = from words in wordCollection
                         where words.Key.Contains(word)
                         select words;

           

            foreach (var entry in result)
                if(entry.Key== word) 
                {
                    foreach (var e in entry.Value) 
                    {
                        valueList.Add(e);
                    }
                }
                //Console.WriteLine("{0} {1} ", entry.Key, string.Join(" ", entry.Value));

            foreach(var t in valueList) 
            {
                Console.WriteLine(t);
            }
        }


        //public static void SeachQuery(Dictionary<string, List<int>> wordCollection)
        //{
        //    var result = from words in wordCollection
        //                 where words.Key.Contains("tablecloth")
        //                 select words;



        //    foreach (var entry in result)
        //        Console.WriteLine("{0} {1} ", entry.Key, string.Join(" ", entry.Value));
        //}
    


      


    }
}



