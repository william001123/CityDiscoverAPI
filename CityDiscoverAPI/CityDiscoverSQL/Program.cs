// See https://aka.ms/new-console-template for more information
using CityDiscoverSQL.Contextos;

Console.WriteLine("Creando la DB si no existe...");
CityDiscoverContexto db = new CityDiscoverContexto();
db.Database.EnsureCreated();
Console.WriteLine("Listo!!!!!");
Console.ReadKey();