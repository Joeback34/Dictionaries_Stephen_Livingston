using System;
using System.Collections.Generic; // namespace that defines the dictionary.
using System.Collections; // namespace that defines the hashTable.



namespace Dictionaries_Stephen_Livingston
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> topGames = new Dictionary<int, string>(); // Creates a dictionary called topGames that contains my 10 favorite games using the .Add key.
            topGames.Add(1,"Monster Hunter World");
            topGames.Add(2, "Overwatch");
            topGames.Add(3, "Deep Rock Galactic");
            topGames.Add(4, "SOMA");
            topGames.Add(5, "Metal Gear Rising");
            topGames.Add(6, "TF2");
            topGames.Add(7, "Portal 2");
            topGames.Add(8, "Lost Planet 2");
            topGames.Add(9, "Hammerwatch");
            topGames.Add(10, "Dead Space");

            foreach(KeyValuePair<int, string> kvp in topGames) // loops through topGames dictionary and prints out each key/value pair on a new line
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
           
            if (topGames.ContainsKey(1)) // checks if topGames contains key 1 and prints the favorite game to the console if it does.
            {
                Console.Write($"\nMy favorite game is: {topGames[1]}"); 
            }

            string result = "";
            topGames.TryGetValue(11, out result);  // Implements th tryGetValue method on tGames for key 11 and sets the output to result string. 

            if(result != "") // if it outputs somthing to result then prints  to the console.
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("There is no game in the eleventh position."); // prints to the console if it returns not equal.
            }

            if (topGames.ContainsKey(5))
            {
                topGames[5] = "DMC5";
            }

            Console.WriteLine(topGames[5]); 

            Hashtable hashTable = new Hashtable(topGames); // creates new hashTable that is set to topGames.

            string favGame = (string)hashTable[1]; // string that is called favGame.

            Console.WriteLine($"Favorite Game: {favGame}");

            Hashtable capitals = new Hashtable()  // creates new hashTables called capitals and 
            {
                { "Oklahoma", "Oklahoma City" },
                { "New York", "Albany" },
                {"Texas", "Austin" },
                {"Ohio", "Columbus" }

            };
            
            foreach (DictionaryEntry kvp in capitals) // loops through capitals hashTable and prints out each key/value pair on a new line.
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            capitals.Clear(); // clears all the elements in the capitals hashtable.
        }   
    }
}
