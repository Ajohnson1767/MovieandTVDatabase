using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieandTVDatabase.Models;
using RestSharp;
using Newtonsoft.Json.Linq;



namespace MovieandTVDatabase
{
    public class MovieRepository : IMovieRepository
    {
        public IEnumerable<MovieModel> GetMovies(string userInput)
        {
           // string userInput = Console.ReadLine();
            //https://movie-database-imdb-alternative.p.rapidapi.com/?s=Avengers%20Endgame&page=1&r=json%22

            var client = new RestClient($"https://movie-database-imdb-alternative.p.rapidapi.com/?s={ userInput }&page=1&r=json%22");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-key", "b58bfcdc3amsh5e45488b1d81bd2p1f9c5cjsn2cfee7755d33");
            request.AddHeader("x-rapidapi-host", "movie-database-imdb-alternative.p.rapidapi.com");
            IRestResponse response = client.Execute(request);

            var movies = JObject.Parse(response.Content).GetValue("Search");

            var list = new List<MovieModel>();

            foreach (var mov in movies)
            {
                var movie = new MovieModel();
                movie.Title = (string)mov["Title"];
                movie.Year = (string)mov["Year"];
                movie.Poster = (string)mov["Poster"];

                list.Add(movie);
            }

            return list;
        }

    }
}
