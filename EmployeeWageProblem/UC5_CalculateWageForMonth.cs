using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    internal class EmpWageUsingSwitch
    {
        public static void GetAttendence()
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");
        }

        public static void EmpWage()
        {
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            //variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
                empHrs = 8;
            //else
            // empHrs = 0;
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage: " + empWage);
            Console.ReadKey();
        }


        public static void PartTimeEmpWage()
        {
            //Constants
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            //variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_PART_TIME)
                empHrs = 4;
            else if (empCheck == IS_FULL_TIME)
                empHrs = 8;
            else
                empHrs = 0;
            empWage = empHrs *
        EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage:" + empWage);
            Console.ReadKey();


        }

        internal class EmployeeWage
        {
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 0;
            const int IS_PRESENT = 1;
            const int IS_ABSENT = 0;
            const int RATE_PER_HOUR = 20;


            public void GetAttendance()
            {
                Random random = new Random();
                int checkAttendance = random.Next(0, 2);
                if (checkAttendance == IS_PRESENT)
                    Console.WriteLine("Is Present");
                else if (checkAttendance == IS_ABSENT)
                    Console.WriteLine("Is Absent");
            }

            public void GetDailyWage()
            {
                int dailyWage = 0;
                int dailyHours = 0;
                Random random = new Random();
                int empCheck = random.Next(0, 2);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        dailyHours = 8;
                        break;
                    case IS_PART_TIME:
                        dailyHours = 4;
                        break;
                    default:
                        dailyHours = 0;
                        break;
                }
                dailyWage = dailyHours * RATE_PER_HOUR;
                Console.WriteLine("Daily Wage: " + dailyWage);
            }

        }
    }
        namespace EmployeeWageProblem

    {
        internal class CalculateWageForMonth
        {//Constants
            public const int IS_PART_TIME = 1;
            public const int IS_FULL_TIME = 2;
            public const int EMP_RATE_PER_HOUR = 20;
            public const int NUM_OF_WORKING_DAYS = 20;
            public static void CalculateWagesFor20DaysInMonth()
            {

                //variables
                int empHrs = 0;
                int empWage = 0;
                int totalEmpWage = 0;
                for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
                {

                    Random random = new Random();
                    int empCheck = random.Next(0, 3);
                    switch (empCheck)
                    {
                        case IS_PART_TIME:
                            empHrs = 4;
                            break;
                        case IS_FULL_TIME:
                            empHrs = 8;
                            break;
                        default:
                            empHrs = 0;
                            break;
                    }
                    empWage = empHrs * EMP_RATE_PER_HOUR;
                    totalEmpWage += empWage;   //int a=6; a+=10;a=a+10
                    Console.WriteLine("Emp Wage: " + empWage);
                }
                Console.WriteLine("Total Emp Wage: " + totalEmpWage);

            }
        }
    

    }


}