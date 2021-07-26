using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokesWebApp.Models
{
    public class Joke
    {
        // Joke properties
        public int Id { get; set; }
        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set; }
        public string JokeTags { get; set; }

        // Joke constructor
        public Joke()
        {

        }
    }
}
