using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            emlpoyee e1 =  new emlpoyee("pankaj",20000,Dept.Testing);
            e1.CalculateSalary();
            Console.WriteLine(e1);

            //Sales_maneger s1 = new Sales_maneger(5000, 30000, "pratik");
            //s1.CalculateSalary();
            //Console.WriteLine(s1.PrintDetails());

            //CEO c1 = new CEO(2000, 30000, "sagar");
            //c1.CalculateSalary();
            //Console.WriteLine(c1.PrintDetails());
            

        }
    }
}
