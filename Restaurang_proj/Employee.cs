namespace Restaurang_proj
{
    internal class Employee
    {
        private string name;

        //Propfull
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        //Prop
        public int Salary { get; set; }

        public Employee(string name,int salary)
        {
            Name = name;
            Salary = salary;
        }
    }
}
