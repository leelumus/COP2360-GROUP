using System;
using System.Collections.Generic;
using System.Linq;

// Liam Mowatt, 
// COP2360
class Program
{
    static void Main()
    {
        // Initialize the dictionary
        Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

        // Main loop for user input
        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("a. Populate the Dictionary");
            Console.WriteLine("b. Display Dictionary Contents");
            Console.WriteLine("c. Remove a Key");
            Console.WriteLine("d. Add a New Key and Value");
            Console.WriteLine("e. Add a Value to an Existing Key");
            Console.WriteLine("f. Sort the Keys");
            Console.WriteLine("q. Quit");

            // Read the user's choice
            string choice = Console.ReadLine();

            // Switch statement to handle different tasks
            switch (choice)
            {
                case "a":
                    PopulateDictionary(dictionary);
                    break;
                case "b":
                    DisplayDictionaryContents(dictionary);
                    break;
                case "c":
                    RemoveKey(dictionary);
                    break;
                case "d":
                    AddNewKeyValue(dictionary);
                    break;
                case "e":
                    AddValueToExistingKey(dictionary);
                    break;
                case "f":
                    SortKeys(dictionary);
                    break;
                case "q":
                    return; // Exit the loop and end the program
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    // Method to populate the dictionary with a key and value
    static void PopulateDictionary(Dictionary<string, List<string>> dict)
    {
        Console.WriteLine("Enter key:");
        string key = Console.ReadLine();
        Console.WriteLine("Enter value:");
        string value = Console.ReadLine();

        // Check if the key exists, if so, add to the list; otherwise, create a new entry
        if (dict.ContainsKey(key))
        {
            dict[key].Add(value);
        }
        else
        {
            dict[key] = new List<string> { value };
        }
        Console.WriteLine($"Added key: {key}, value: {value}");
    }

    // Method to display the contents of the dictionary
    static void DisplayDictionaryContents(Dictionary<string, List<string>> dict)
    {
        Console.WriteLine("Dictionary Contents:");
        foreach (var kvp in dict)
        {
            Console.WriteLine($"Key: {kvp.Key}, Values: {string.Join(", ", kvp.Value)}");
        }
    }

    // Method to remove a key from the dictionary
    static void RemoveKey(Dictionary<string, List<string>> dict)
    {
        Console.WriteLine("Enter the key to remove:");
        string key = Console.ReadLine();

        // Attempt to remove the key, displaying appropriate message based on the outcome
        if (dict.Remove(key))
        {
            Console.WriteLine($"Removed key: {key}");
        }
        else
        {
            Console.WriteLine($"Key {key} not found.");
        }
    }
   
}
