using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Employees
{
    public class FixedPaymentEmployee : BaseEmployee
    {
        decimal fixedSalary;
        public FixedPaymentEmployee() {}
        public FixedPaymentEmployee (string lastName, decimal fixedSalary)
        {
            base.LastName = lastName;
            this.fixedSalary = fixedSalary;
            СalculateAverageMonthlySalary();
        }

        public override void СalculateAverageMonthlySalary()
        {
            AverageMonthlySalary = fixedSalary;
        }
    }
}
