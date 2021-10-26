using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootdirectory = @"C:\Users\opilane\samples";
            string userdirevtory = "wishlist";

            string newDirctoryFullPath = @$"{rootdirectory}\{userdirevtory}";

            Console.WriteLine(newDirctoryFullPath);

            Directory.CreateDirectory(newDirctoryFullPath);
        }
    }
}
