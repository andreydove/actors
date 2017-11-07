using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actors.Model
{
    public class Genres : Entity
    {
        public string Genre{ get; set; }
        public int GenreID { get; set; }
        //public Genres(string genre)
        //{
        //    Genre = genre;
        //}
        //public override string ToString()
        //{
        //    return String.Format("{0}", Genre);
        //}

       
    }
}
