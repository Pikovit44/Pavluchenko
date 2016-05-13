using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class EmployeeContainer
    {
        public List<BaseEmployee> employees;

        public EmployeeContainer(string path)
        {
            DeserialazeContainer(path);
        }

        public EmployeeContainer(List<BaseEmployee> employees)
        {
            this.employees = employees;
        }

        public void DeserialazeContainer(string path)
        {
            XmlSerializer xmlserialazer = new XmlSerializer(typeof(List<BaseEmployee>));

            try
            {
                using (StreamReader r = new StreamReader(path))
                {
                    employees = (List<BaseEmployee>)xmlserialazer.Deserialize(r);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can't read input file. Exit from application.");
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }

        public void SerialazeContainer(string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<BaseEmployee>));
            using (StreamWriter w = new StreamWriter(path))
            {
                xmlSerializer.Serialize(w, employees);
            }
        }

    }
}
