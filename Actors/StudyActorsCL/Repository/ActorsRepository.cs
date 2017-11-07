using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Actors.Model;

namespace Actors.Repository
{
    public partial class ActorsRepository : EntityRepository
    {

        public ActorsRepository(string directory = "")
            : base(directory)
        {
        }

        Dictionary<int, Actor> actors = new Dictionary<int, Actor>();
        Dictionary<int, Competition> competitions = new Dictionary<int, Competition>();
        Dictionary<int, Country> countries = new Dictionary<int, Country>();
        Dictionary<int, Films> film = new Dictionary<int, Films>();
        Dictionary<int, Genres> genres = new Dictionary<int, Genres>();
        Dictionary<int, Results> results = new Dictionary<int, Results>();
        Dictionary<int, Roles> roles = new Dictionary<int, Roles>();
        List<GenreOfFilms> genreOfFilms = new List<GenreOfFilms>();
    }
}
