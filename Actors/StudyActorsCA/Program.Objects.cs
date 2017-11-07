using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Actors.Model;

namespace Actors
{
    partial class Program
    {
        public static string ToString<T>(IEnumerable<T> objectEnum, string prompt = "")
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\n{0}:\n", prompt);
            foreach (T e in objectEnum)
            {
                sb.AppendFormat("\t {0} \n", e.ToString());
            }
            return sb.ToString();
        }


        static IEnumerable<T> Filter<T>(
            IEnumerable<T> objectEnum,
            Func<T, bool> selector)
        {
            foreach (T e in objectEnum)
            {
                if (selector(e))
                    yield return e;
            }
        }

        static void ConsoleOut<T>(IEnumerable<T> objectEnum, string prompt)
        {
            Console.WriteLine(ToString(objectEnum, prompt));
        }


        static void Objects()
        {
            Actors();
        }

        static void Actors()
        {
            Console.WriteLine("---ACTORS---");

            Actor act1 = new Actor();

            act1.CommonName = "Ем!л!я Кларк";
            act1.MaritalStatus = "в!льна";
            act1.Sex = false;
            act1.BirthDate = new DateTime(1987, 5, 1);

            Console.WriteLine("\nact1:\t{0}", act1.CommonName);
            Console.WriteLine("\nact1:\t{0}", act1.ToString());

            Actor act2 = new Actor("В!лл См!т")
            {
                FormalName = "В!ллард Кр!стофер «В!лл» См!т молодший",
                MaritalStatus = "одружений",
                Sex = true,
                BirthDate = new DateTime(1968, 9, 25),
            };

            Console.WriteLine("\nact2:\t{0}", act2.ToString());

            Actor act3 = new Actor("Дензел Вашингтон", "Дензел Гейз Вашингтон, молодший", "одружений", true)
            {
                BirthDate = new DateTime(1954, 12, 28),
            };
            Console.WriteLine("\nact3:\t{0}", act3.ToString());

            Actor act4 = new Actor("Емма Робертс", "Емма Роуз Робертс", "заручена", true)
            {
                BirthDate = new DateTime(1991, 2, 10),
            };
            Console.WriteLine("\nact4:\t{0}", act4.ToString());

            Actor act5 = new Actor("Емма Стоун", "Емілі Джин «Емма» Стоун", "є хлопець", false)
            {
                BirthDate = new DateTime(1988, 11, 6),
            };
            Console.WriteLine("\nact5:\t{0}", act5.ToString());

            Actor act6 = new Actor("Марк Волберг", "Марк Роберт Майкл Волберг", "одружений", true)
            {
                BirthDate = new DateTime(1971, 6, 5),
            };
            Console.WriteLine("\nact6:\t{0}", act6.ToString());

            //-------------------------------------
            Country ctr3 = new Country("США");
            Console.WriteLine("\nctr3: {0}", ctr3.ToString());

            //-------------------------------------
            Films film3 = new Films("Тренувальний день", "Warner Brothers");
            film3.ReleaseDate = new DateTime(2001, 1, 1);
            Console.WriteLine("\nfilm3: {0}", film3.ToString());

            //-------------------------------------
            Results res3 = new Results("Краща чоловіча роль","Перемога",2012);
            Console.WriteLine("\nres3: {0}", res3.ToString());

            //-------------------------------------
           

        }

    }
}
