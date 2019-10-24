using System;
using System.Collections.Generic;
using System.Text;


namespace Restaurang_proj
{
    class Emp
    {
        private string name;
        private double lön;
        /* public Emp_ifno (string Enmp_name , double Emp_lön )
         {

         }*/
        public void Add_Emp(string Emp_name, double Emp_lön)


        {
            var add_Emp_name = new List<string>();
            var add_Emp_Lön = new List<double>();

            // string Emp_name ;
            //var Emp_Lön = 0.0;

            foreach (var emp in add_Emp_name)
            {
                add_Emp_name.Add(Emp_name);
                add_Emp_Lön.Add(Emp_lön);
            }

            Console.WriteLine("Employee Name        Employee Lön");
            Console.WriteLine(Emp_name, Emp_lön);

        }
    }
}
