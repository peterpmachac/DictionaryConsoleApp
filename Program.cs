namespace DictionaryConsoleApp
{

    class Program
    {
        static void Main(string[] args)
        {
            // get only duplicates from a string
            string testString = "Hello, this is a string about Mookey & Moosley, they are cows, Moo!";
            Console.WriteLine(ReverseEachWord.ReverseWords(testString));
        }

        public static void GetcharCountShort(string testString)
        {
            Dictionary<char, int> duplicates = GetcharCount(testString);
            foreach (var w in duplicates)
            {

                Console.WriteLine(w.Key + "- " + w.Value);

            }
        }

        public static Dictionary<char, int> GetcharCount(string input)
        {
            var charOccurance = new Dictionary<char, int>();
            foreach (var i in input)
            {
                if (charOccurance.ContainsKey(i))
                {

                    charOccurance[i]++;
                }

                else
                {
                    charOccurance[i] = 1;
                }
            }
            return charOccurance.Where(a => a.Value > 1).ToDictionary(a => a.Key, a => a.Value); // only duolocates not sinlge ones
                                                                                                 //  return charOccurance.ToDictionary(a => a.Key, a => a.Value);
        }
    }



    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // not duplicated: n g b u k & c !
    //        string myString = "Hello, this is a string about Mookey & Moosley, they are cows, Moo!";

    //        //Dictionary.SendMeLetters(myString);
    //        //Dictionary.SendMeMoreLetters(myString);
    //        // Dictionary.ParseCustomString(myString);


    //        //DictionaryConsoleApp.Repeating.SendMeLetters(myString);
    //        //Console.WriteLine(myString.GroupBy(n => n).Count(p => p.Count() >=2));
    //        // See https://aka.ms/new-console-template for more information

    //        //Repeating.cleanDups(myString);

    //        Console.WriteLine(HashTableTest.CheckChar("sweet lady let's talk"));

    //    }
    //}
}















