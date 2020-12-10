using MovieandTVDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieandTVDatabase
{
    public interface IMovieRepository
    {
        public IEnumerable<MovieModel> GetMovies(string userInput);
    }
}
