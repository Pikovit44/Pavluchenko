using Employee.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Employee
{
    [Serializable]
    [XmlInclude(typeof(HourlyPaymentEmployee))]
    [XmlInclude(typeof(FixedPaymentEmployee))]
    public abstract class BaseEmployee
    {
        public readonly int Id;
        public BaseEmployee()
        {
            Id = Handler.GetId();
        }

        public string LastName { get; set; }
        public decimal AverageMonthlySalary { get; set; }
        public abstract void СalculateAverageMonthlySalary();
    }
}
