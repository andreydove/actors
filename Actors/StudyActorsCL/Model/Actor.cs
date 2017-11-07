using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Actors.Model
{               //Actor.cs є основним класом
    public class Actor : Entity   //Actor є похідним від базового класу Entity, що містить ID
    {
        public string CommonName { get; set; }
        public string FormalName { get; set; }
        public int CountryID { get; set; }
        //↓ опис полів таблиці бази даних ↓
        public string MaritalStatus { get; set; }

        public bool Sex { get; set; }
        public DateTime BirthDate;
        
        public int Age
        {
            get
            {   //↓ визначення віку актора ↓
                DateTime now = DateTime.Now;
                int age = now.Year - BirthDate.Year;
                if (now.Month < BirthDate.Month
                    || now.Month == BirthDate.Month
                    && now.Day < BirthDate.Day)
                    age--;
                return age;
            }
        }
        //↓ опис методу виведення інформації про актора ↓ 
        public override string ToString()
        {
            return String.Format(
                "\n{0} {1} \nдата народження: {2} \nв!к {3} рок!в \nc!мейний стан: {4}",
                Sex ? "Актор: " : "Акторка: ", CommonName, BirthDate.ToShortDateString(), Age, MaritalStatus);
        }
        //↓ опис конструкторів ↓
        public Actor(string commonName = null)
        {
            CommonName = commonName;
        }

        public Actor(string commonName, string formalName, string maritalStatus, bool sex)
        {
            CommonName = commonName;
            FormalName = formalName;
            MaritalStatus = maritalStatus;
            Sex = sex;        
        }

    }
}
