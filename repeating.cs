using System;

namespace DictionaryConsoleApp
{
    public class Repeating
    {
        public static void SendMeLetters(string myString)
        {
            List<string> repeatingLetters = new List<string>();

            for(int i = 0; i < myString.Length; i++)
            {
                for (int x = 0; x < myString.Length; x++)
                {
                    if (myString[i] == myString[x] && i != x)
                    {
                        repeatingLetters.Add(myString[i].ToString());
                    }
                }
            }
            //foreach (char c in myString.ToLower())
            //{
            //    foreach (char d in myString.ToLower())
            //    {
            //        if (c == d)
            //        {
            //            repeatingLetters.Add(d);
            //        }
            //    }
            //}

            foreach (string c in repeatingLetters.Distinct())
            {
                Console.WriteLine(c);
            }

            Console.WriteLine(myString);
        }

        public static void cleanDups(string myString)
        {
            char[] Array = myString.ToCharArray();
            var duplicates = Array.GroupBy(p => p).Where(g => g.Count() > 1).Select(g => g.Key).ToList();
            string duplicateval = string.Join(",", duplicates.ToArray());
            Console.WriteLine(duplicateval);
        }

        void RepeatedLetters()
        {
            string word = "wooooooow";
            var distinctChars = word.Distinct();
            foreach (char c in distinctChars)
                if (word.Count(p => p == c) > 1)
                {
                    // do work on c
                }
            //s.GroupBy( c => c ).FirstOrDefault( group => group.Count() > 1 ) != null ;
        }




        // https://www.google.com/search?q=c%23+find+duplicate+characters+in+string&sca_esv=da56b67854fd2398&rlz=1C1OPNX_enUS1096US1096&sxsrf=ACQVn08CfqmaaEtKRAAr6ogx-XL_cPHe-Q%3A1710400444372&ei=vKPyZaKtFqjdkPIPiZ2-8Ag&oq=c%23+duplicate+characters+in+string&gs_lp=Egxnd3Mtd2l6LXNlcnAiIWMjIGR1cGxpY2F0ZSBjaGFyYWN0ZXJzIGluIHN0cmluZyoCCAAyBhAAGAcYHjIGEAAYBxgeMgYQABgIGB4yBhAAGAgYHjIGEAAYCBgeMgYQABgIGB4yBhAAGAgYHjIGEAAYCBgeMgYQABgIGB4yBhAAGAgYHkiqKlCxDlixDnACeAGQAQCYAWKgAWKqAQExuAEDyAEA-AEBmAIDoAJ-wgIKEAAYRxjWBBiwA5gDAIgGAZAGCJIHAzIuMaAHvgk&sclient=gws-wiz-serp
        // From: https://stackoverflow.com/questions/18133022/how-to-check-repeated-letters-in-a-string-c-sharp

        //class Program
        //{
        //    static void Main(string[] args)
        //    {
        //        // get only duplicates from a string
        //        string testString = "AABCDEEGTT";
        //        Dictionary<char, int> duplicates = GetcharCount(testString);
        //        foreach (var w in duplicates)
        //        {

        //            Console.WriteLine(w.Key + "- " + w.Value);

        //        }
        //    }

        //    public static Dictionary<char, int> GetcharCount(string input)
        //    {
        //        var charOccurance = new Dictionary<char, int>();
        //        foreach (var i in input)
        //        {
        //            if (charOccurance.ContainsKey(i))
        //            {

        //                charOccurance[i]++;
        //            }

        //            else
        //            {
        //                charOccurance[i] = 1;
        //            }
        //        }
        //        return charOccurance.Where(a => a.Value > 1).ToDictionary(a => a.Key, a => a.Value); // only duolocates not sinlge ones
        //                                                                                             //  return charOccurance.ToDictionary(a => a.Key, a => a.Value);
        //    }
        //}
    }
}