using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main (string[] args)
        {
            // build a list of two planets
            List<string> planetList = new List<string> () { "Mercury", "Mars" };

            // add two planets to that list
            planetList.Add ("Jupiter");
            planetList.Add ("Saturn");

            // Create a new list with the last 3 planets
            List<string> lastPlanets = new List<string> () { "Uranus", "Neptune", "Pluto" };

            // Add those planets to the original list
            planetList.AddRange (lastPlanets);
            planetList.Insert (1, "Venus");
            planetList.Insert (2, "Earth");

            // Separate the rocky planets: Mercury, Venus, Earth and Mars
            List<string> rockyPlanets = planetList.GetRange (0, 4);

            // Pluto isn't a planet so remove it
            planetList.Remove ("Pluto");

            // rockyPlanets.ForEach (planet => Console.WriteLine (planet));
            // planetList.ForEach (planet => Console.WriteLine (planet));

            Random random = new Random ();
            List<int> numbers = new List<int>
            {
                random.Next (6),
                random.Next (6),
                random.Next (6),
                random.Next (6),
                random.Next (6),
                random.Next (6),
            };

            for (int i = 0; i < numbers.Count; i++)
            {
                // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.

                if (numbers.Contains (i))
                {
                    Console.WriteLine ($"Numbers list contains {i}");
                }
                else
                {
                    Console.WriteLine ($"Numbers List does not contain {i}");
                };
            }

            /*
            Create a dictionary with key value pairs to
            represent words (key) and its definition (value)
            */
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string> ();

            // Add several more words and their definitions
            wordsAndDefinitions.Add ("Awesome", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add ("Helpless", "The feeling of students when they are learning JavaScript");
            wordsAndDefinitions.Add ("Anxious", "The feeling of students when they are learning Git");
            wordsAndDefinitions.Add ("Euphoric", "The feeling of students when they are learning Python");

            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */
            Console.WriteLine (wordsAndDefinitions["Helpless"]);
            Console.WriteLine (wordsAndDefinitions["Anxious"]);

            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
            */
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine ($"The definition of {word.Key} is {word.Value}");
            }

            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>> ();

            /*
                You want to track the following about each word:
                    word, definition, part of speech, example sentence
            */

            // Create dictionary to represent a few words
            Dictionary<string, string> excitedWord = new Dictionary<string, string> ();

            // Add each of the 4 bits of data about the word to the Dictionary
            excitedWord.Add ("word", "excited");
            excitedWord.Add ("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
            excitedWord.Add ("part of speech", "adjective");
            excitedWord.Add ("example sentence", "I am excited to learn C#!");

            // Add Dictionary to your `dictionaryOfWords` list
            dictionaryOfWords.Add (excitedWord);
            // create another Dictionary and add that to the list

            Dictionary<string, string> anxiousWord = new Dictionary<string, string> ();

            anxiousWord.Add ("word", "anxious");
            anxiousWord.Add ("definition", "experiencing worry, unease, or nervousness, typically about an imminent event or something with an uncertain outcome.");
            anxiousWord.Add ("part of speech", "adjective");
            anxiousWord.Add ("example sentence", "I am anxious to learn C#!");

            dictionaryOfWords.Add (anxiousWord);
            /*
                Iterate your list of dictionaries and output the data, You can use the two foreach() loops below to help you start your iteration.

                Example output for one word in the list of dictionaries:
                    word: excited
                    definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                    part of speech: adjective
                    example sentence: I am excited to learn C#!
            */

            // Iterate the List of Dictionaries
            foreach (Dictionary<string, string> word in dictionaryOfWords)
            {
                // Iterate the KeyValuePairs of the Dictionary
                foreach (KeyValuePair<string, string> wordData in word)
                {
                    Console.WriteLine ($"{wordData.Key}: {wordData.Value}");
                }
            }

        }
    }
}