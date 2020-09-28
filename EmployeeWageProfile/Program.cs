using System;

namespace EmployeeWageProfile
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);

            if (empCheck == IS_FULL_TIME)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is not present");
        }
    }
}
