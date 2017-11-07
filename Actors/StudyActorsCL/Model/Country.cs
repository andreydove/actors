using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actors.Model
{
    public class Country : Entity
    {
        public string CountryName { get; set; }
        public int CountryID { get; set; }
        public Country(string countryName = null)
        {
            CountryName = countryName;
        }
        public override string ToString()
        {
            return String.Format("\nКраїна народження: {0}", CountryName);
        }
    }
}
