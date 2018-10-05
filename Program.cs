using System;
using System.Collections.Generic;

namespace lists {
    class Program {
        static void Main (string[] args) {
            // Create a list of planets containing mercury and mars.
            List<string> planetList = new List<string> () { "Mercury", "Mars" };

            // Add jupiter and saturn to the end of planetList.
            planetList.Add ("Jupiter");
            planetList.Add ("Saturn");

            // Create a second planet list containing nepture and uranus.
            List<string> planetListTwo = new List<string> () { "Neptune", "Uranus" };

            // Insert Venus and Earth into planetList at index 1 and 2.
            planetList.Insert (1, "Venus");
            planetList.Insert (2, "Earth");

            // Add planetListTwo at the end of planetList
            planetList.AddRange (planetListTwo);

            // Add pluto the the end of the planet list
            planetList.Add ("Pluto");

            // Select the first four indexes from planetList
            // Assign those four planets to the list called rockyPlanets
            List<string> rockyPlanets = planetList.GetRange (0, 4);

            // Remove the planet at index 8 (pluto) from planetList
            planetList.RemoveAt (8);

            // Create list containing a dictionary named probes

            List<Dictionary<string, string>> probes = new List<Dictionary<string, string>> ();

            // Create a dictionaries for each probe to hold key value pairs
            Dictionary<string, string> viking = new Dictionary<string, string> () {
                {"Mars", "Viking"},
                {"Jupiter", "Viking"}
            };

            Dictionary<string, string> opportunity = new Dictionary<string, string> () {
                {"Mars", "Opportunity"}
            };

            Dictionary<string, string> trident = new Dictionary<string, string> () {
                {"Neptune", "Trident" }
            };

            // Add the above dictionaries to the probes dictionary
            probes.Add (viking);
            probes.Add (opportunity);
            probes.Add (trident);

            // Iterate planets
            foreach (string planet in planetList) 
            {
                // Create a list named matchingProbes
                List<string> matchingProbes = new List<string>();

                // Iterate probes
                foreach (Dictionary<string, string> probe in probes)
                {
                    // Link key value pairs of dictionary probes to planets list by the dictionary keys
                    if(probe.ContainsKey(planet)){
                        // Add the probes that match planets to the list matchingProbes
                        matchingProbes.Add(probe[planet]);
                    }
                }
                
                // If there are no probes that match a planet, do not list the planet.
                if(matchingProbes.Count > 0) {
                    // Write to console the planets and their matching probes,
                    // joining the probes with a comma and space.
                    Console.WriteLine($"{planet}: {String.Join(", ", matchingProbes)}");
                }
            }
        }
    }
}