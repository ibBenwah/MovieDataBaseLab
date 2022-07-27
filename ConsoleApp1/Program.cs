
using MovieDatabaseLab;

Movie movieOne = new Movie("Batman", "Action") { };
Movie movieTwo = new Movie("Spider-Man", "Action") { };
Movie movieThree = new Movie("Forrest Gump", "Drama") { };
Movie movieFour = new Movie("Dune", "Scifi") { };
Movie movieFive = new Movie("Jaws", "Action") { };
Movie movieSix = new Movie("The Godfather","Drama") { };
Movie movieSeven = new Movie("UP", "Animated") { };
Movie movieEight = new Movie("Toy Story", "Animated") { };
Movie movieNine = new Movie("Interstellar","Scifi") { };
Movie movieTen = new Movie("House of Gucci", "Drama") { };
Movie movieEleven = new Movie("The Incrediables","Animated") { };
Movie movieTwelve = new Movie("Inception", "Scifi") { };

List<Movie> movies = new List<Movie>() { movieOne, movieTwo, movieThree, movieFour, movieFive, movieSix, movieSeven, movieEight, movieNine, movieTen, movieEleven, movieTwelve};
var movieList = movies.Select(m => m.Title).ToList();
//movieList.ForEach(x => Console.WriteLine(x));


Console.WriteLine("Welcome to the Movie List Application");
Console.WriteLine();
Console.WriteLine("There are " + movieList.Count() + " movies in this list");
Console.WriteLine();
Console.WriteLine ("What category are you interested in? ");
Console.Write($"Action, Anamated, Drama, Sifi: ");
string selection = Console.ReadLine();

foreach (Movie movie in movies)
{
    if (selection == movie.Category)
    {

        movie.PrintMovieDetails();
    
    }
}
