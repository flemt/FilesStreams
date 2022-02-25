using System;

namespace FilesStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFileHandler fileHandler = new MyFileHandler();
            fileHandler.ReadAllContent("testfile1.txt");
            fileHandler.WriteContentToFile("testar och skrvia något jhär");
            fileHandler.UpperCaseContent(@"C:\Users\sildo\Desktop\FilesStreams\FilesStreams\testfile1.txt", @"C:\Users\sildo\Desktop\FilesStreams\FilesStreams\testfile3.txt");
            fileHandler.ReadLAtinEncodedContent();
        }
    }
}
