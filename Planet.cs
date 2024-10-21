using System;

public class Planet
{
    public string Name { get; set; }
    public int Population { get; set; }
    public string Region { get; set; }

    public Planet(string name, int population, string region)
    {
        Name = name;
        Population = population;
        Region = region;
    }

    public void DisplayPlanetInfo()
    {
        Console.WriteLine($"Planet Name: {Name}, Population: {Population}, Region: {Region}");
    }
}
