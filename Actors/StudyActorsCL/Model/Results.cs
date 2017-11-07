using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actors.Model
{
    public class Results : Entity
    {
        public string Nomination { get; set; }
        public string Value{ get; set; }
        public int Year { get; set; }
        public int CompetitionID { get; set; }
        public string Result {
            get { return Result; }
            set {if(value == null)
                return;}
        }

        public Results( string nomination = "", string result = "", int year = 0)
        {
            Nomination = nomination;
            Result = result;
            Year = year;
        }
        public override string ToString()
        {
            return String.Format("\nНом!нац!я: {0}, hезультат: {1}, р!к: {2}", Nomination, Result, Year);
        }

    }
}
