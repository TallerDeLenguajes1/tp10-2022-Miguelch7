using System.Text.Json.Serialization;

public class Technology
{
  [JsonPropertyName("id")]
  public int Id { get; set; }

  [JsonPropertyName("name")]
  public string? Name { get; set; }

  [JsonPropertyName("description")]
  public string? Description { get; set; }

  [JsonPropertyName("expansion")]
  public string? Expansion { get; set; }

  [JsonPropertyName("age")]
  public string? Age { get; set; }

  [JsonPropertyName("develops_in")]
  public string? DevelopsIn { get; set; }

  [JsonPropertyName("cost")]
  public Cost? Cost { get; set; }

  [JsonPropertyName("build_time")]
  public int BuildTime { get; set; }

  [JsonPropertyName("applies_to")]
  public List<string>? AppliesTo { get; set; }

  public void showTechnology() {
    Console.WriteLine($"Id: { Id }");
    Console.WriteLine($"Name: { Name }");
    Console.WriteLine($"Description: { Description }");
    Console.WriteLine($"Expansion: { Expansion }");
    Console.WriteLine($"Age: { Age }");
    Console.WriteLine($"DevelopsIn: { DevelopsIn }");
    Console.WriteLine("Cost:");
    Console.WriteLine($"    Food: { Cost.Food }");
    Console.WriteLine($"    Wood: { Cost.Wood }");
    Console.WriteLine($"BuildTime: { BuildTime }");

    Console.WriteLine("AppliesTo:");
    if (AppliesTo != null)
    {
      foreach (string appliesTo in AppliesTo)
      {
        Console.WriteLine("    " + appliesTo);
      }
    }
  }

}



