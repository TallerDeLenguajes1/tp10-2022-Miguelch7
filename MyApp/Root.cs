using System.Text.Json.Serialization;

public class Root
{
  [JsonPropertyName("civilizations")]
  public List<Civilization>? Civilizations { get; set; }

  public int obtenerCantidad() {
    if (Civilizations != null) {
      return Civilizations.Count();
    } else {
      return 0;
    };
  }

  public void listarTodas() {
    if (Civilizations != null) {
      foreach (Civilization civilization in Civilizations) {
        Console.WriteLine($"{ civilization.Id }) { civilization.Name }");
      };
    }
  }
}
