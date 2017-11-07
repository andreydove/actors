using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actors.Model
{
    public class GenreOfFilms :Entity
    {
        public int GenreID { get; set; }
        public int FilmID { get; set; }
        //public int Genres { get; set; }
    }
}
