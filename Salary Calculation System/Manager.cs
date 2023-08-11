using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Calculation_System
{
    internal class Manager:Employee
    {
        private const decimal Allowance = 100;
        public override decimal CalculateGroosPay() => base.CalculateGroosPay() + Allowance;
        public override void DisplayAllData()
        {
            base.DisplayAllData();
            Console.WriteLine($"Allowance:{Allowance}");
        }


    }
}
