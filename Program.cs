using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Planet> planets = new List<Planet>
        {
            new Planet("Tatooine", 200000, "Outer Rim Territories"),
            new Planet("Coruscant", 1000000000, "Core Worlds"),
            new Planet("Naboo", 450000000, "Mid Rim"),
            new Planet("Endor", 30000, "Outer Rim Territories")
        };

        Console.WriteLine("Initial list of planets:");
        foreach (var planet in planets)
        {
            planet.DisplayPlanetInfo();
        }

        planets.Sort((x, y) => x.Population.CompareTo(y.Population));
        Console.WriteLine("\nPlanets sorted by population:");
        foreach (var planet in planets)
        {
            planet.DisplayPlanetInfo();
        }

        while (true)
        {
            Console.Write("\nWould you like to add a new planet? (yes/no): ");
            string answer = Console.ReadLine();
            if (answer.ToLower() != "yes") break;

            AddPlanet(planets);
        }
    }

    static void AddPlanet(List<Planet> planets)
    {
        Console.Write("Enter the name of the planet: ");
        string name = Console.ReadLine();

        Console.Write("Enter the population of the planet: ");
        int population;

        while (!int.TryParse(Console.ReadLine(), out population) || population < 0)
        {
            Console.Write("Please enter a valid population (positive integer): ");
        }

        Console.Write("Enter the region of the planet: ");
        string region = Console.ReadLine();

        Planet newPlanet = new Planet(name, population, region);
        planets.Add(newPlanet);
        planets.Sort((x, y) => x.Population.CompareTo(y.Population));

        Console.WriteLine("New planet added successfully!");
        foreach (var planet in planets)
        {
            planet.DisplayPlanetInfo();
        }
    }
}
