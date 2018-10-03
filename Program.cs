using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> planetListTwo = new List<string>(){"Neptune", "Uranus"};
            
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            planetList.AddRange(planetListTwo);

            planetList.Add("Pluto");

            List<string> rockyPlanets = planetList.GetRange(0, 4);

            planetList.RemoveAt(8);

            planetList.ForEach(planet => Console.WriteLine(planet));
        }
    }
}
