using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Calculation_System
{
    internal class Handyman:Employee
    {
        public decimal Hardship { get; set; }
        public  override decimal CalculateGroosPay() => base.CalculateGroosPay();
        public  override void DisplayAllData()
        {
            base.DisplayAllData();
            Console.WriteLine($"Hardship:{Hardship}");
        }



    }
}
