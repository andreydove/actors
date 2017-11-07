using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actors.Model
{
    public class Films : Entity
    {
        public string FilmName { get; set; }
        public int FilmID { get; set; }
        public DateTime ReleaseDate;
        public string Studio { get; set; }

        public Films(string filmName = null)
        {
            FilmName = filmName;
        }
        public Films(string filmName, string studio)
        {
            FilmName = filmName;
            Studio = studio;
        }
        public override string ToString()
        {
            return String.Format("\nНазва стр!чки: {0} \nдата виходу: {1} \nк!ностуд!я: {2}", FilmName, ReleaseDate.Year, Studio);
        }

    }
}
