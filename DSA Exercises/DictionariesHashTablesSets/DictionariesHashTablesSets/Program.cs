namespace DictionariesHashTablesSets
{
    using System.Collections;

    public class Program
    {
        // Dictionaries, Hash Tables and Sets (2013)
        private static void Main(string[] args)
        {
            Dictionary<int, int> myDictionary = new();

            myDictionary[1] = 111;
            myDictionary.Add(2, 222);
            myDictionary.Add(3, 333);
            myDictionary.Add(4, 444);

            foreach (KeyValuePair<int, int> kvp in myDictionary)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }

            Console.WriteLine("----------");

            Hashtable myHashtable = new();

            myHashtable.Add(1, 11);
            myHashtable.Add(2, 22);
            myHashtable.Add(3, 33);
            myHashtable.Add(4, 44);
            myHashtable[5] = 55;
            myHashtable.Add("a", 901);
            myHashtable["b"] = 902;
            myHashtable.Add("c", 903);
            myHashtable["d"] = 904;

            //print hashtable
            foreach (DictionaryEntry dictionaryEntry in myHashtable)
            {
                Console.WriteLine($"{dictionaryEntry.Key} - {dictionaryEntry.Value}");
            }
        }
    }
}