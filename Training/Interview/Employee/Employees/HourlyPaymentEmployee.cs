using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Employees
{
    public class HourlyPaymentEmployee: BaseEmployee
    {
        decimal hourlySalary;
        public HourlyPaymentEmployee() { }
        public HourlyPaymentEmployee(string lastName, decimal hourlySalary)
        {
            base.LastName = lastName;
            this.hourlySalary = hourlySalary;
            СalculateAverageMonthlySalary();
        }

        public override void СalculateAverageMonthlySalary()
        {
            AverageMonthlySalary = 21 * 8 * hourlySalary;
        }

    }
}
