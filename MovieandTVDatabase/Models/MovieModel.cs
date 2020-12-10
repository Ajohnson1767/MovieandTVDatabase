using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using RestSharp;
using MovieandTVDatabase.Models;

namespace MovieandTVDatabase.Models
{
    public class MovieModel
    {
        public MovieModel()
        {

        }
        public string Title { get; set; }
        public string Year { get; set; }

        public string Poster { get; set; }
    }
}
