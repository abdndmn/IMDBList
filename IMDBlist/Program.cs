using System.Runtime.CompilerServices;
using System.Threading.Channels;
namespace ImdbList
{
    public class Movies
    {
        public string MovieTitle { get; set; }//properties
        public double ImdbScore { get; set; }


    }
    class Program
    {

        static void Main(string[] args)
        {
            List<Movies> movies = new List<Movies>();//movies list
            while (true)
            {
                Console.WriteLine("IMDB Film listesine eklemek istediğiniz film adını giriniz:");
                string movieTitle = Console.ReadLine();
                
                Console.WriteLine("Lütfen eklediğiniz filmin IMDB puanını giriniz:");
                double imdbScore;
                while(!double.TryParse(Console.ReadLine(), out imdbScore) || imdbScore < 0 || imdbScore > 10)//imdb skorları 0 ile 10 arasında olmalı.
                {
                    Console.WriteLine("Lütfen 0 ile 10 arasında bir puan giriniz:");
                }

                Movies movie = new Movies();
                movie.MovieTitle = movieTitle;
                movie.ImdbScore = imdbScore;

                movies.Add(movie);

                Console.WriteLine("Daha fazla film eklemek için 'evet' yazınız, tamamladıysanız 'hayır' yazınız:");
                string check = Console.ReadLine().Trim().ToLower();

                if (check == "hayır" || check == "hayir")
                {
                    Console.WriteLine("Liste tamamlandı.");
                    break;
                }
            }

            Console.WriteLine("\nTüm Filmler:");
            foreach (var movie in movies)
            {
                Console.WriteLine($"Film: {movie.MovieTitle}, IMDB Puanı: {movie.ImdbScore}");
            }

            Console.WriteLine("\nIMDB Puanı 4 ile 9 arasında olan Filmler:");
            foreach (var movie in movies)
            {
                if (movie.ImdbScore >= 4 && movie.ImdbScore <= 9)
                {
                    Console.WriteLine($"Film: {movie.MovieTitle}, IMDB Puanı: {movie.ImdbScore}");
                }
            }

            Console.WriteLine("\nİsmi 'A' ile başlayan Filmler:");
            foreach (var movie in movies)
            {
                if (movie.MovieTitle.StartsWith("A", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Film: {movie.MovieTitle}, IMDB Puanı: {movie.ImdbScore}");
                }
            }
        }
    }
}