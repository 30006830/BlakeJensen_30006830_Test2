/*Blake Jensen (30006830)
Test 2 22/05/2019*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2Assessment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White; //makes the text in the start window white for easy reading.
            Salary s1 = new Salary(); //new object created with appropriate naming.

            Console.Write("\n"); //blank lines
            Console.Write("\n");

            Console.ReadLine();
        }
    }
    class Salary
    {
        private double annualSalary { get; set; } = 80000; //hardcoded to be 80000
        private double weeklySalary { get; set; } //getting and setting
        //both variables have been made private, if left alone it would be automatically assigned to being private regardless

        public Salary() //Salary constructor w/ msg
        {
            Console.WriteLine("Your Annual Salary per year is $" + annualSalary);
            Console.WriteLine($"Your Weekly Salary has been calculated to: ${Math.Round(DisplaySalary(), 2)}");
        }

        public Salary(double annualsalary, double weeklysalary)
        {
            annualSalary = annualsalary;
            weeklySalary = weeklysalary;
        }
        
        public double DisplaySalary() //method used to calculate the Weekly Salary.
        {
            return weeklySalary + (1000 / 1);
        }
    }

    class Wages
    {
        private double hourlyRate { get; set; } = 33.72; //hardcoded to be 33.72 since that is what the wages are.
        private double weeklyWages { get; set; } 
        private int numHours { get; set; } //set as an int because hours are usually calculated in whole numbers

    }
}
