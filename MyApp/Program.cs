using System.Net;
using System.Text.Json;

// Genera un numero random y lo 
var numRandom = new Random().Next(1, 140);
Technology technology = getTechnologyById(numRandom);

// Mostrar technology
technology.showTechnology();

// ----- Funciones -----
Technology getTechnologyById(int id)
{
  Technology technology = new Technology();

  var url = $"https://age-of-empires-2-api.herokuapp.com/api/v1/technology/{ id }";

  var request = (HttpWebRequest)WebRequest.Create(url);
  request.Method = "GET";
  request.ContentType = "application/json";
  request.Accept = "application/json";

  try
  {
    using (WebResponse response = request.GetResponse())
    {

      using (Stream strReader = response.GetResponseStream())
      {

        if (strReader != null)
        {

          using (StreamReader objReader = new StreamReader(strReader))
          {

            string responseBody = objReader.ReadToEnd();

            technology = JsonSerializer.Deserialize<Technology>(responseBody);
          }
        }
      }
    }
  }
  catch (WebException)
  {
    Console.WriteLine("Ocurrió un error");
  }
  
  return technology;
}