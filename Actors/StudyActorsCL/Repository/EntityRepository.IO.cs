using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;
//using System.Data;

using Actors.Model;

namespace Actors.Repository
{

    public abstract partial class EntityRepository
    {

        private string filePath;
        private string directory;

        public string Directory
        {
            get { return directory; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    string exeName =
                        Assembly.GetExecutingAssembly().Location;
                    directory =
                        Path.GetDirectoryName(exeName) + "\\Repository";
                }
                else
                {
                    directory = value.Trim();
                }
                if (!File.Exists(directory))
                    System.IO.Directory.CreateDirectory(directory);
                filePath = directory + "\\";
            }
        }

        public EntityRepository(string directory = "")
        {
            this.Directory = directory;
        }

        public void Load(string fileName)
        {
            if (String.IsNullOrWhiteSpace(fileName))
            {
                throw new Exception(
                    "Не вказано ім'я файлу для завантаження");
            }

            string fullName = fileName.Trim();
            string ext = Path.GetExtension(fullName);//.ToLower()
            if (String.IsNullOrWhiteSpace(ext))
            {
                ext = ".xml";
                fullName = fullName + ext;
            }

            string dirName = Path.GetDirectoryName(fullName);
            if (dirName == "")
            {
                fullName = filePath + fileName;
            }
            else if (!File.Exists(fullName))
            {
                throw new FileNotFoundException(
                    "Не знайдено файл " + fullName);//?
            }

            ext = ext.ToLower();
            if (ext == ".xsd" || ext == ".xml")
            {
                LoadXml(fullName);
            }
            else
            {
                throw new Exception(
                    "Сховище не підтримує збереження "
                    + "у файлі формату " + ext.ToUpper());
            }
        }


        public void Save(string fileName)
        {
            if (String.IsNullOrWhiteSpace(fileName))
            {
                throw new Exception(
                    "Не вказано ім'я файлу для збереження");
            }

            string fullName = fileName.Trim();
            string dirName = Path.GetDirectoryName(fullName);
            if (dirName == "")
            {
                fullName = filePath + fileName;
            }
            //else if (!File.Exists(dirName)) {
            else if (!System.IO.Directory.Exists(dirName))
            {
                throw new FileNotFoundException(
                    "Не знайдено каталог " + dirName);//?
            }

            string ext = Path.GetExtension(fullName);//.ToLower()
            if (String.IsNullOrWhiteSpace(ext))
            {
                //ext = ".txt";
                ext = ".xml";
                fullName = fullName + ext;
            }
            ext = ext.ToLower();
            if (ext == ".txt")
            {
                File.WriteAllText(fullName, this.ToString());
            }
            else if (ext == ".xsd" || ext == ".xml")
            {
                SaveXml(fullName);
            }
            else
            {
                throw new Exception(
                    "Сховище не підтримує збереження "
                    + "у файлі формату " + ext.ToUpper());
            }
        }
    }
}
