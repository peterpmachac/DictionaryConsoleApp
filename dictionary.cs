using Newtonsoft.Json;
using System.Text.Json;


namespace DictionaryConsoleApp
{
    internal class Dictionary
    {
        public static void SendMeLetters(string myString)
        {
            string jsonString = "{\"key1\": \"value1\", \"key2\": \"value2\"}";

            Dictionary<string, string> dictionary = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(jsonString);

            foreach (KeyValuePair<string, string> entry in dictionary)
            {
                Console.WriteLine("Key: " + entry.Key + ", Value: " + entry.Value);
            }
        }
        public static void SendMeMoreLetters(string myString)
        {
            // JSON string to be converted
            string jsonString = "{\"key1\": \"value1\", \"key2\": \"value2\"}";

            Dictionary<string, string> dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonString);

            foreach(KeyValuePair<string, string> entry in dictionary)
            {
                Console.WriteLine("Key: " + entry.Key + ", Value: " + entry.Value);
            }
        }

        public static void ParseCustomString(string myString)
        {
            string inputString = "key1=value1;key2=value2";

            string[] keyValuePairs = inputString.Split(';');

            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            foreach(string pair in keyValuePairs)
            {
                string[] parts = pair.Split('=');
                if(parts.Length == 2)
                {
                    string key = parts[0];
                    string value = parts[1];
                    dictionary[key] = value;
                }
            }

            foreach(KeyValuePair<string, string> entry in dictionary)
            {
                Console.WriteLine("Key: " + entry.Key + ", Value: " + entry.Value);
            }
        }
    }
}
