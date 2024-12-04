using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryConsoleApp
{
    public class HashTableTest
    {

        static public string? CheckChar(string str)
        {
            Hashtable tempDictionary = new Hashtable();

            foreach(char c in str)
            {
                try
                {
                    tempDictionary.Add(c, c.ToString());
                }
                catch
                {
                    return c.ToString();
                }
            }
            return null;
        }
    }
}
