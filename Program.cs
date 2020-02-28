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

        }
    }
}