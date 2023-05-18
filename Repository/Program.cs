// See https://aka.ms/new-console-template for more information
using Movies.Business;

Console.WriteLine("App N-Layer");

Console.WriteLine("Movies");

var moviesBusiness = new MovieBusiness();

var movies = moviesBusiness.GetAll();

foreach (var m in movies)
{
    Console.WriteLine($" |_ {m.Name}");
}

Console.ReadKey();
