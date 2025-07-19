using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class01_OOP
{
    internal struct Employee
    {
        #region Attributes
        private int Id;
        private string Name;
        private decimal Salary;
        #endregion

        #region Constructors
        public Employee(int _id, string _name, decimal _salary)
        {
            Id = _id;
            Name = _name;
            Salary = _salary;
        }
        #endregion

        #region Methods
        // Applying Encapsulation by getter and setter in Name
        public string GetName()
        {
            return Name;
        }

        public void SetName(string _name)
        {
            Name = _name;
        }

        // Applying Encapsulation by Property 

        public decimal Salaryy {
            get { return Salary; }
            set { Salary = value; }
        }


        public override string ToString()
        {
            return $"My name is {Name} and my code is {Id} meanwhile salary is {Salary}";
        }
        #endregion
    }
}
