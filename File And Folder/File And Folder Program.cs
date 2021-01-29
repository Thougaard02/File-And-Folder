using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace File_And_Folder
{
    class File_And_Folder_Program
    {
        public void Menu()
        {
            //Used to see files in the path
            string path = @".\";
            string seachPattern = "*";

            //Menu Layout
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("               H1 Queue Operation Menu              ");
            Console.WriteLine();
            Console.WriteLine("====================================================");
            Console.WriteLine("1. Add File");
            Console.WriteLine("2. Delete File");
            Console.WriteLine("3. Display Files");
            Console.WriteLine("4. Add Folder");
            Console.WriteLine("5. Search File");
            Console.WriteLine("6. Exit");

            int userOption = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(userOption);

            //Could be change to a switch statement!!!!
            //If userOption is equal it will run the method in the statement
            if (userOption == 1)
            {
                Console.Clear();
                AddFile();
            }
            else if (userOption == 2)
            {
                Console.Clear();
                DeleteFile(path, seachPattern);
            }
            else if (userOption == 3)
            {
                Console.Clear();
                ShowFiles(path, seachPattern);
            }
            else if (userOption == 4)
            {
                Console.Clear();
                CreateFolder(path);
            }
            else if (userOption == 5)
            {
                Console.Clear();
                ShowFiles(path);
            }
            else if (userOption == 6)
            {
                Environment.Exit(0);
            }
        }
        #region Methodes
        //Creates a file
        private void CreateFile(string path)
        {
            File.Create(path);
        }
        //Creates a folder
        private static void CreateDirectory(string path)
        {
            Directory.CreateDirectory(path);
            Console.WriteLine("Directory created!");
        }
        //Deletes a file
        private static void DeleteFil(string path)
        {
            File.Delete(path);
            Console.WriteLine("File has been deleted!");
        }
        //Deletes a folder
        private static void DeleteFolder(string path, bool recursive)
        {
            Directory.Delete(path, recursive);
            Console.WriteLine("Folder has been deleted!");
        }
        //Printes the file the in the path
        private static void GetFiles(string path, string searchPattern, SearchOption searchOption)
        {
            string[] files = Directory.GetFiles(path, searchPattern, searchOption);
            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine(files[i]);
            }
        }
        #endregion
        #region Option Methodes
        //Creates a file
        private void AddFile()
        {
            try
            {
                Console.WriteLine("Type your filename");
                string userInput = Console.ReadLine();
                if (!File.Exists($@".\{userInput}.txt"))
                {
                    Console.WriteLine("does not exists");
                    CreateFile($"{userInput}.txt");
                    Console.WriteLine("File has been created!");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("File already exists!");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Wrong input");
                Thread.Sleep(500);
                Console.Clear();
                Menu();
            }
        }
        //Deletes a file
        private void DeleteFile(string path, string searchPattern)
        {
            try
            {
                Console.WriteLine("All your files can be seen under!\n");
                GetFiles(path, searchPattern, SearchOption.AllDirectories);
                Console.WriteLine("\nName the file");
                Console.WriteLine("TYPE THE FILENAME you want to delete!!");
                string userInput = Console.ReadLine();
                if (!File.Exists($@".\{userInput}.txt"))
                {
                    Console.WriteLine("File doesn't exists");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                }
                else
                {
                    DeleteFil($@".\{userInput}.txt");
                    Console.WriteLine($"File has been deleted {$@"{userInput}.txt"}!");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Wrong input");
                Thread.Sleep(500);
                Console.Clear();
                Menu();
            }
        }
        //Printes the all file the in the path
        private void ShowFiles(string path, string searchPattern)
        {
            try
            {
                GetFiles(path, searchPattern, SearchOption.AllDirectories);
                Console.WriteLine("\nPress any key to return to menu");
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Wrong input");
                Thread.Sleep(500);
                Console.Clear();
                Menu();
            }
        }
        //Creates a folder
        private void CreateFolder(string path)
        {
            try
            {
                Console.WriteLine("Type your folder name");
                string userInput = Console.ReadLine();
                if (!Directory.Exists($"{path}\\{userInput}"))
                {
                    CreateDirectory($"{path}\\{userInput}");
                    Console.WriteLine("Folder has been created!");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                }
                else
                {
                    Console.WriteLine("Folder already exists!");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Wrong input");
                Thread.Sleep(500);
                Console.Clear();
                Menu();
            }
        }
        //Printes the file depends on the userinput in the path
        private void ShowFiles(string path)
        {
            try
            {
                Console.WriteLine("Type the file format you want to search after!");
                string userInput = $"*{Console.ReadLine()}";
                GetFiles(path, userInput, SearchOption.AllDirectories);
                Console.WriteLine("\nPress any key to return to menu");
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Wrong input");
                Thread.Sleep(500);
                Console.Clear();
                Menu();
            }
        }
        #endregion
    }
}
