using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Calculation_System
{
    internal class Software_Engineer:Employee
    {
        public const decimal SoftwareEngineerBonusAmount = 40.0m;
        public const int SoftwareEngineerStoryPointThreshold = 8;
        public decimal TrainingAllowance { get; set; }
        public int StoryPointCompleted { get; set; }

        public  decimal ClaculateBounsAmount() =>
            StoryPointCompleted >= SoftwareEngineerStoryPointThreshold ? SoftwareEngineerBonusAmount : 0;

        public  override decimal CalculateGroosPay() =>
            base.CalculateGroosPay() + ClaculateBounsAmount() + TrainingAllowance;
        public  override void DisplayAllData()
        {
            base.DisplayAllData();
            Console.WriteLine($"SoftwareEngineerBonusAmount:{SoftwareEngineerBonusAmount}");
            Console.WriteLine($"ClaculateBounsAmount:{ClaculateBounsAmount()}");
        }







    }
}
