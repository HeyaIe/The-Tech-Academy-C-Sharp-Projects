using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartOne
{
    class Program
    {
        static void Main()
        {
            // Introduction
            Console.WriteLine("Console App Assignment Part One");

            // Initalize an array of strings
            string[] strArray = { "bada", "bing", "wit", "a", "pipe" };

            // Prompt user for a string input
            Console.WriteLine("Please enter some text.");
            string text = Console.ReadLine();

            // Part two - add a potential infinite loop
            // Flag
            bool isDone = false;

            while (!isDone)
            {
                foreach (string elem in strArray)
                {
                    Console.WriteLine(elem + text);
                }
                isDone = true;
            }
            // Part three - two loops with different conditions
            Console.WriteLine("\nPart three");

            string[] strArray1 = { "roll", "with", "the", "punches" };

            // Prompt user for a string input
            Console.WriteLine("Please enter some text.");
            string text1 = Console.ReadLine();
            
            // Using "<" operator
            for(int i = 0; i < strArray1.Length; ++i)
            {
                if(i != 2)
                {
                    Console.WriteLine(strArray1[i] + text1);
                }
            }

            Console.WriteLine("\nUsing \"<=\" operator");

            for(int i = 0; i < strArray1.Length; ++i)
            {
                // Using "<=" operator
                if(i <= 1)
                {
                    Console.WriteLine(strArray1[i] + text1);
                }
                else
                {
                    break;
                }
            }

            // Part 4
            Console.WriteLine("\nPart 4");

            // Initialize a list of strings
            List<string> strList = new List<string>() { "Search", "for", "the", "index", "using", "searched", "word" };

            // Display all the strings in the list
            foreach(string word in strList)
            {
                Console.WriteLine(word);
            }

            // Prompt the user to enter one of the words from the list
            Console.WriteLine("\nPlease enter one of the words above to display the index of entered word.");
            string entered = Console.ReadLine();

            for(int i = 0; i < strList.Count; ++i)
            {
                if(strList[i] == entered)
                {
                    Console.WriteLine("Result: " + i);
                    break;
                }
                else if (!strList.Contains(entered))
                {
                    Console.WriteLine("Word not found in the list.");
                    break;
                }
            }

            // Part 5 - list with at least two identical strings
            Console.WriteLine("\nPart 5");

            // Initialize a list of strings
            List<string> strList1 = new List<string>() { "late", "mate", "date", "fate", "date", "date", "slate", "skate", "late" };

            // Display all string from the list
            foreach(string word in strList1)
            {
                Console.WriteLine(word);
            }

            // Flag
            bool isFound = false;

            // While loop
            while (!isFound)
            {
                Console.WriteLine("\nPlease enter a word from the above list to determine the index from it.");
                string word1 = Console.ReadLine();

                for(int i = 0; i < strList1.Count; ++i)
                {
                    // If word found, display the index/indices of entered word and set flag to true
                    if (strList1[i] == word1)
                    {
                        Console.WriteLine("Result: " + i);
                        isFound = true;
                    }
                    // Display message if entered word is not in the list
                    else if(!strList1.Contains(word1))
                    {
                        Console.WriteLine("Try again.");
                        break;
                    }
                }
            }

            // Part 6 - Use a foreach loop
            Console.WriteLine("\nPart 6");

            // Initalize a list of strings with at least two identical strings
            List<string> strList2 = new List<string>() { "cart", "tart", "start", "smart", "smart", "counterpart", "flowchart", "smart" };

            // Decalre a new list
            List<string> strList3 = new List<string>();

            string message = " - This word has been displayed before";

            foreach(string word in strList2)
            {
                if (!strList3.Contains("String: " + word))
                {
                    // If new list does not contain the string above, add it.
                    strList3.Add("String: " + word);
                }
                else
                {
                    // Display message if string has been displayed before.
                    strList3.Add("String: " + word + message);
                }
            }

            // Display each string from the new list
            foreach(string str in strList3)
            {
                Console.WriteLine(str);
            }

            Console.Read();
        }
    }
}
