using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using FightClubApp.Game.Inerfaces;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace FightClubApp.Game
{
    public class WorkWithFile
    {
        IData data = null;
        string dataFile = @".\Data.dat";
        public WorkWithFile(IData data)
        {
            this.data = data;
        }


        Data [] table = new  Data [20];

        public void AddData()
        {
            table = ReadFile();
            for (int i = 0; i < table.Length; i++)
            {
                if (!(table[i].Name == data.Name))
                {
                    for (int j = 0; j < table.Length; j++)
                    {
                        if (table[j].Name == "пусто")
                        {
                            table[j].Name = data.Name;
                            table[j].NumberOfFight = data.NumberOfFight;
                            table[j].NumberOfWin = data.NumberOfWin;
                            table[j].NumberOfTie = data.NumberOfTie;
                            table[j].NumberOfLoss = data.NumberOfLoss;
                        }
                    }    
                }
            }
            Array.Sort(table);
            WriteFile();
        }

        BinaryFormatter formatter = new BinaryFormatter();

        public void WriteFile()
        {
            using (FileStream fs = new FileStream(dataFile, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, table);
            }
        }

        public Data [] ReadFile()
        {
            if (File.Exists(dataFile))
            {
                using (FileStream fs = new FileStream(dataFile, FileMode.Open))
                {
                    return (Data [])formatter.Deserialize(fs);
                }
            }
            else
            {
                for (int i = 0; i < table.Length; i++)
                {
                    table[i] = (new Data("пусто", 0, 0, 0, 0));
                }
                return table;
            }

        }






        //XmlSerializer formatter = new XmlSerializer(typeof(Data));
        //using (FileStream fs = new FileStream("data.xml", FileMode.OpenOrCreate))
        //{

        //}




    }
}
