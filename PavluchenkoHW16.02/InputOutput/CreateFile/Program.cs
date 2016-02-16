using System;
using System.IO;

namespace CreateFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Konstantin\Documents\GitHub\Pavluchenko\PavluchenkoHW16.02\CreateFile\SomeFile.txt";
            string test = "Text for SomeFile.txt";

            try
            {
                using (BinaryWriter writerBin = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
                {
                    writerBin.Write(test);
                }
                    
                
                using (BinaryReader readerBin = new BinaryReader(File.Open(path, FileMode.Open)))
                {
                    while (readerBin.PeekChar() > -1)
                    {
                        string readTest = readerBin.ReadString();
                        Console.WriteLine("Текст прочитанный из файла: {0}", readTest);
                    } 
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadLine();
        }
    }
}
