using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Folders
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Konstantin\Documents\GitHub\Pavluchenko\PavluchenkoHW16.02\InputOutput\Folders";
            string subPath = "Folder_";
            try
            {
                DirectoryInfo foldersInfo = new DirectoryInfo(path);

                if (!foldersInfo.Exists)
                {
                    foldersInfo.Create();
                }

                
                for (int i = 0; i < 100; i++)
                {
                    foldersInfo.CreateSubdirectory(subPath + i);
                }
                Console.WriteLine("1.Папки созданы. \nВремя создания каталога: {0}", foldersInfo.CreationTime);

                foldersInfo.Delete(true);
                Console.WriteLine("2.Папки удалены.");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString()); ;
            }

            

        }
    }
}
