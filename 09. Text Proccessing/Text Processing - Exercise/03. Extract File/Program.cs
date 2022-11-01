using System;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split('\\');

            string[] fileInfo = text[text.Length - 1].Split('.');

            string fileName = fileInfo[0];
            string fileExtension = fileInfo[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
