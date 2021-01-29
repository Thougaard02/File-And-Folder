using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.AccessControl;

namespace File_And_Folder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Runs the class File_And_Folder_Program
            File_And_Folder_Program program = new File_And_Folder_Program();
            program.Menu();

            #region File / Directory
            //Path
            //string path = @"Droids\protocol";

            #region Opg 1
            //Files path and writes inside the file
            //string fileName = $"{path}\\protocol.txt";
            //string contents = "Hello World!";

            //WriteAllText(fileName, contents);
            #endregion

            #region Opg 2
            //Read the text inside file.
            //ReadAllText(path);
            #endregion

            #region Opg 3
            ////Deletes file
            //DeleteFile(path);
            #endregion

            #region Opg 4
            //Create a directory
            //CreateDirectory(path);
            #endregion

            #region Opg 5
            //Deletes folder
            //DeleteFolder(path, true);

            #endregion

            #region Opg 6

            #endregion
            //Enumerating files
            //string seachPattern = "*";
            //GetFiles(path, seachPattern, SearchOption.AllDirectories);
            #endregion
            #region Stream
            //string filePath = @"Movies.txt";
            //Create file
            //CreateFile(filePath);

            //Writing to .txt
            //string text = "Star wars\nThe Impire Strickes Back\nReturn of the jedi\n";
            //WriteToFile(filePath, text);

            //Writing a collection
            //CollectionWrite(filePath);

            //Reads the whole file becuase the function "ReadToEnd()"
            //ReadFile(filePath);

            //Append text
            //AppendText(filePath, text);

            #endregion
            Console.ReadKey();
        }


        #region File / Directory

        //public static void WriteAllText(string fileName, string contens)
        //{
        //    File.WriteAllText(fileName, contens);
        //    Console.WriteLine("File created!");
        //}
        //public static void ReadAllText(string path)
        //{
        //    string readFile = File.ReadAllText(path);
        //    Console.WriteLine(readFile);
        //}
        //public static void CreateDirectory(string path)
        //{
        //    Directory.CreateDirectory(path);
        //    Console.WriteLine("Directory created!");
        //}

        //public static void DeleteFile(string path)
        //{
        //    File.Delete(path);
        //    Console.WriteLine("File has been deleted!");
        //}
        //public static void DeleteFolder(string path, bool recursive)
        //{
        //    Directory.Delete(path, recursive);
        //    Console.WriteLine("Folder has been deleted!");
        //}

        public static void GetFiles(string path, string searchPattern, SearchOption searchOption)
        {
            string[] files = Directory.GetFiles(path, searchPattern, searchOption);
            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine(files[i]);
            }
        }
        #endregion
        #region Stream

        //static void CreateFile(string filePath)
        //{
        //    FileStream create = new FileStream(filePath, FileMode.Create);

        //    Console.WriteLine("File has been created!");
        //}
        //static void ReadFile(string filePath)
        //{
        //    FileStream file = new FileStream(filePath, FileMode.Open);
        //    StreamReader reader = new StreamReader(file);
        //    Console.WriteLine(reader.ReadToEnd());
        //    file.Close();
        //}

        //static void WriteToFile(string filePath, string text)
        //{
        //    using (StreamWriter writer = new StreamWriter(new FileStream(filePath, FileMode.Create)))
        //    {
        //        writer.WriteLine(text);
        //    }

        //    //File.AppendAllText(filePath, text);
        //    Console.WriteLine("Writing done");
        //}
        //static void CollectionWrite(string filePath)
        //{
        //    string[] jedis = new[] { "Luke Skywalker", "Yoda", "Mace Windu" };
        //    foreach (string jedi in jedis)
        //    {
        //        File.AppendAllText(filePath, jedi);
        //    }
        //}
        ////static void CollectionWrite(string filePath)
        ////{
        ////    string[] actors = new[] { "Mark Hamill\n", "Harrision Ford\n", "Carrie Fisher\n" };
        ////    foreach (string actor in actors)
        ////    {
        ////        File.AppendAllText(filePath, actor);
        ////    }
        ////}
        //static void AppendText(string filePath, string text)
        //{
        //    File.AppendAllText(filePath, text);
        //}
        #endregion
    }
}
