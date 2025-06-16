  using System;
using System.Collections.Generic;
using System.Linq;

public class DSolution
{
    // public int LongestSquareStreak(int[] nums) {
        
    // }

  
}


public class City
{
    public string Name { get; set; }
    public int Population { get; set; }

    public City(string name, int population)
    {
        Name = name;
        Population = population;
    }
}

public class Country
{
    public string Name { get; set; }
    public List<City> Cities { get; set; }

    public Country(string name)
    {
        Name = name;
        Cities = new List<City>();
    }

    public void SetCities(List<City> cities)
    {
        Cities = cities;
    }
}

class Program2
{
    public static void Main2()
    {
        // Create countries with cities
        var spain = new Country("Spain");
        spain.SetCities(new List<City>
        {
            new City("Barcelona", 2),
            new City("Madrid", 3),
            new City("Valencia", 5)
        });

        var france = new Country("France");
        france.SetCities(new List<City>
        {
            new City("Paris", 4),
            new City("Marseille", 2),
            new City("Lyon", 6)
        });


        var countries = new List<Country>{spain, france};

        var cityPopulation = countries.Select(x => x.Cities.OrderByDescending(c => c.Population).Select(con => new {Country = x.Name, City = con.Name, Pop = con.Population}).First()).OrderByDescending(pl => pl.Pop).FirstOrDefault();
        //Using LINQ to find the country with the city having the highest population
        var countryWithHighestPopulation = (from country in new List<Country> { spain, france }
                                           let mostPopulousCity = country.Cities.OrderByDescending(c => c.Population).First()
                                           orderby mostPopulousCity.Population descending
                                           select new { country.Name, City = mostPopulousCity.Name })
                                          .FirstOrDefault();

        Console.WriteLine($"{countryWithHighestPopulation.Name} : {countryWithHighestPopulation.City}");
        string test = "";
    }
}
