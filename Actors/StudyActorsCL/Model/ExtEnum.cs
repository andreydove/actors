using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actors.Model
{
    public static class ExtEnum
    {
        public static string ToString<T>(this IEnumerable<T> objectEnum, string prompt)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\n{0}: \n", prompt);
            foreach (T e in objectEnum)
            {
                sb.AppendFormat("\t {0} \n", e.ToString());
            }
            return sb.ToString();
        }


        public static IEnumerable<T> Filter<T>(
            this IEnumerable<T> objectEnum,
            Func<T, bool> selector)
        {
            foreach (T e in objectEnum)
            {
                if (selector(e))
                    yield return e;
            }
        }

        public static void ConsoleOut<T>(this IEnumerable<T> objectEnum, string prompt)
        {
            Console.WriteLine(ToString(objectEnum, prompt));
        }
    }
}
