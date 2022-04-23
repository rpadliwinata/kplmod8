using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace modul8_1302200028.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private static List<Movie> movies = new List<Movie>
        {
            new Movie("The Shawshank Redemption", "Frank Darabont", new List<string>{"Tim Robbins", "Morgan Freeman", "Bob Gunton", "William Sadler"}, "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency."),
            new Movie("The Godfather", "Francis Ford Coppola", new List<string>{"Marlon Brando", "Al Pacino", "James Caan", "Diane Keaton"}, "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son."),
            new Movie("The Dark Knight", "Christopher Nolan", new List<string>{"Christian Bale", "Heath Ledger", "Aaron Eckhart", "Michael Caine"}, "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.")
        };

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return movies;
        }

        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            return movies[id];
        }

        [HttpPost]
        public Movie Post([FromBody] Movie movie)
        {
            movies.Add(movie);
            return movie;
        }

        [HttpDelete]
        public Movie Delete(int id)
        {
            Movie deleted = movies[id];
            movies.RemoveAt(id);
            return deleted;
        }

    }
}
