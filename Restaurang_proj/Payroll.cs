using System.Collections.Generic;

namespace Restaurang_proj
{
    internal class Payroll
    {
        private List<Employee> employees ;
        public Payroll()
        {
            employees = new List<Employee>();
        }

        internal void add (string name,int salary) 
        {
        }
        public override string ToString()
        {
            return $"Name: {name} Salary:{salary}";
        }
    }
}