using System.Text.Json.Serialization; 

public class StarwarsSpecies
{

    [JsonPropertyName("name")]
    public string Name { get; set; } 
}
