using RestSharp;
using System.Text.Json;  
using System.IO; 
 
RestClient client = new ("https://swapi.py4e.com/api/"); 

string starwarsName = ""; 
RestRequest request = new($"planets/");
RestResponse response = client.GetAsync(request).Result;

StarwarsResult planets = JsonSerializer.Deserialize<StarwarsResult>(response.Content);


Console.WriteLine(planets.results.Count);

//Starwars p = JsonSerializer.Deserialize<Starwars>(response.Content); 
//Console.WriteLine(p.Name); 

Console.ReadLine(); 