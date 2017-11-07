using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actors.Model
{
    public class Competition : Entity
    {
        public string Competitions { get; set; }
        public int CompetitionID { get; set; }
        //public Competition(string comp)
        //{
        //    Competitions = comp;
        //}
        //public override string ToString()
        //{
        //    return String.Format("{0}", Competitions);
        //}
    }
}
