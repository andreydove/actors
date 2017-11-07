using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Actors.Model;
using Actors.Repository;

namespace Actors
{
    partial class Program
    {
        static void StudyRepository()
        {
            StudyRepositoryIO();
        }

        static void StudyRepositoryIO()
        {
            Console.WriteLine("!----StudyRepositoryIO----");
            EntityRepository repository = new ActorsRepository();

            //try
            //{
            //    repository.Save("Actors.xsd");
            //}
            //catch (FileNotFoundException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //try
            //{
            //    repository.Save(null);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);

            //}

            //try
            //{
            //    repository.Save("d:\\program\\file");
            //}
            //catch (FileNotFoundException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //try
            //{
            //    repository.Save("Actors!!!");
            //}
            //catch (FileNotFoundException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //try
            //{
            //    repository.Save("AcTr.exe");
            //}
            //catch (FileNotFoundException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //try
            //{
            //    repository.Save("");
            //}
            //catch (FileNotFoundException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

        }

    }
}

