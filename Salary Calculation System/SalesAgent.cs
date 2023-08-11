using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Calculation_System
{
    internal class SalesAgent : Employee
    {
        private const decimal Comission = (decimal)0.0005;
        public decimal TotalSalse { get; set; }
        public decimal CalculateComissionAmount() => TotalSalse * Comission;
      public override decimal CalculateGroosPay() => base.CalculateGroosPay() + CalculateComissionAmount();
        public override void DisplayAllData()
        {
            base.DisplayAllData();
            Console.WriteLine($"Comission:{Comission}");
            Console.WriteLine($"TotalSalse:{TotalSalse}"); 
            Console.WriteLine($"CalculateComissionAmount:{CalculateComissionAmount()}"); 
        }

    }
}
