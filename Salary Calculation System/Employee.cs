using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Calculation_System
{
    internal abstract class  Employee
    {
        public  const decimal TaxAmount =(decimal) 0.10;
        public  const decimal OverTime = (decimal) 1.5;
        private int _id ;
        private string _fristname ;
        private string _lastname ;
        private decimal _hourlyRate;
        private int _expectedhours; 
        private int _loggedhours;
        public int Id 
        {
            get 
            {
                return _id;
            }
            set 
            {
                if (value <= 0)
                    throw new ArgumentException("invalid id"); 
                _id = value ;
            }

        }
        public decimal HourlyRate 
        {
            get { return _hourlyRate; }    
            set 
            {
                if (_hourlyRate < 0)
                    throw new ArgumentException("invalid HourlyRate !"); 
                _hourlyRate = value ;
            }
        }
        public int LoggedHours 
        {
            get { return _loggedhours; }
            set 
            {
                if (value < 0)
                    throw new ArgumentException("ivalid LoggedHours "); 
                _loggedhours = value ;
            }
        }
        public int Expectedhours 
        {
            get { return _expectedhours; }
            set { _expectedhours = value;  }
        }
        public void FullName(string fristname, string lastname)
        {
            if (string.IsNullOrWhiteSpace(fristname) || string.IsNullOrWhiteSpace(lastname))
                throw new ArgumentException("invalid fullname");
            _fristname = fristname;
            _lastname = lastname;
        }

        public decimal CalculateBasiceSalry() =>    HourlyRate * LoggedHours; 
        
        public decimal CalculateOverTimeAmount()
        {
            int HourDeviation = LoggedHours - Expectedhours; 
            return Math.Max(HourDeviation, 0) * HourlyRate * OverTime;
        }
        public virtual decimal CalculateGroosPay() => CalculateBasiceSalry() + CalculateOverTimeAmount();
        public virtual decimal CalculateTaxRate() => CalculateGroosPay() * TaxAmount;
        public virtual decimal CalculateNetSalary() => CalculateGroosPay() - CalculateTaxRate();

        public virtual void DisplayAllData()
        {
            Console.WriteLine($"Employee id: {Id}");
            Console.WriteLine($"Employee name: {_fristname} {_lastname}");
            Console.WriteLine($"Hourly rate: ${HourlyRate}");
            Console.WriteLine($"Expected hours: {Expectedhours}");
            Console.WriteLine($"Logged hours: {LoggedHours}");
            Console.WriteLine($"Basic salary: ${CalculateBasiceSalry()}");
            Console.WriteLine($"Overtime amount: ${CalculateOverTimeAmount()}");
            Console.WriteLine($"Gross pay: ${CalculateGroosPay()}");
            Console.WriteLine($"Tax rate: ${CalculateTaxRate()}");
            Console.WriteLine($"Net salary: ${CalculateNetSalary()}");
        }


    }
}
