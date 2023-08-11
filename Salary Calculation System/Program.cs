using System;

namespace Salary_Calculation_System
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Employee manager = new Manager();
            manager.Id = 1002;
            manager.FullName("Ahmed", "Samir");
            manager.HourlyRate = 10.0m;
            manager.Expectedhours = 40;
            manager.LoggedHours = 45;

            Employee salesAgent = new SalesAgent();
            salesAgent.Id = 1002;
            salesAgent.FullName("Ali", "Abdallah");
            salesAgent.HourlyRate = 10.0m;
            salesAgent.Expectedhours = 40;
            salesAgent.LoggedHours = 45;
            

            Employee handyman = new Handyman();
            handyman.Id = 1003;
            handyman.FullName("Ibrahim", "Sayed");
            handyman.HourlyRate = 5.0m;
            handyman.Expectedhours = 40;
            handyman.LoggedHours = 65;
            ((Handyman)handyman).Hardship = 75;

            Employee softwareEngineer = new Software_Engineer();
            softwareEngineer.Id = 1004;
            softwareEngineer.FullName("Nour", "Ali");
            softwareEngineer.HourlyRate = 10.0m;
            softwareEngineer.Expectedhours = 40;
            softwareEngineer.LoggedHours = 40;
        
            DisplayEmployeeData(manager);
            DisplayEmployeeData(salesAgent);
            DisplayEmployeeData(handyman);
            DisplayEmployeeData(softwareEngineer);
        }

        public static void DisplayEmployeeData(Employee employee)
        {
            Console.WriteLine($"------ {employee.GetType().Name} ---------");
            employee.DisplayAllData();
            Console.WriteLine();
        }
    }

    
}
