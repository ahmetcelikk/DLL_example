using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    public class Employee
    {
        public int Number;
        public string Name, Adress;
        public decimal Salary;
        public DateTime Date;

        public int Info(int number,string name,string adress,decimal salary,DateTime date)
        {
            this.Number = number;
            this.Name = name;
            this.Adress = adress;
            this.Salary = salary;
            this.Date = date;
            return Number;
        }
    }

}
