using System;
using System.Collections.Generic;

namespace Restaurang_proj
{
    class Resurang
    {
        private static object util;

        static void Main(string[] args)
        {
            Payroll payroll = new Payroll();

            Console.WriteLine("Enter A New Employee");

            bool correct = true;
            do
            {
                string name = Util.AskForString("Name:");
                if (name == "Q") break;
                int salary = Util.askforint();
            } while (true);
        }
    }
}
