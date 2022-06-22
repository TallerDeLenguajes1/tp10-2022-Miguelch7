
using System.Text.Json.Serialization;

public class Cost
{
  [JsonPropertyName("Food")]
  public int Food { get; set; }

  [JsonPropertyName("Wood")]
  public int Wood { get; set; }
}

