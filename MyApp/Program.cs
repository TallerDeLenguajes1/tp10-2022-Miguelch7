using System.Net;
using System.Text.Json;

// Se obtienen las civilizaciones
Root listadoCivilizaciones = obtenerCivilizaciones();

listadoCivilizaciones.listarTodas();

// Se cuentan los resultados
Console.WriteLine($"\nSe han encontrado { listadoCivilizaciones.obtenerCantidad() } civilizaciones");

Console.Write("\nElija una civilizacion (por su id) para mostrar su contenido: ");
int idCivilizacion = Convert.ToInt32(Console.ReadLine());


Civilization civilizacionEncontrada = listadoCivilizaciones.Civilizations[idCivilizacion - 1];

if (civilizacionEncontrada != null)
{
  Console.WriteLine($"\nDetalle de la civilización cuyo id es { idCivilizacion }: ");
  civilizacionEncontrada.mostrarCivilizacion();
}

// ----- Funciones -----
Root obtenerCivilizaciones()
{
  Root listadoCivilizaciones = new Root();

  var url = "https://age-of-empires-2-api.herokuapp.com/api/v1/civilizations";

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

            listadoCivilizaciones = JsonSerializer.Deserialize<Root>(responseBody);
          }
        }
      }
    }
  }
  catch (WebException)
  {
    Console.WriteLine("Ocurrió un error");
  }

  return listadoCivilizaciones;
}