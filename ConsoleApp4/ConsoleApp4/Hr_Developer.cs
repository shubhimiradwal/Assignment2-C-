using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class Hr_Developer : abstractclas
    {
        public int Basicsalaryhr, experienceyear,Basicsalarydev;

        public Hr_Developer()
        {

        }
        public void  Hrsalary()
        {
            Basicsalaryhr = 8000;
            experienceyear = 4;
            Annual_salary = Basicsalaryhr + (experienceyear * 1000);
            Console.WriteLine(Annual_salary);
        }
        public void DeveloperSalary()
        {
            Basicsalarydev = 8000;
            experienceyear = 5;
            Annual_salary = Basicsalarydev+( experienceyear * 2000);
            Console.WriteLine(Annual_salary);
        }
    }
}
