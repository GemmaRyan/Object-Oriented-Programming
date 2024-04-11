using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Q1
{
    class Employee
    {
        //  attributes 
        private string _gender;
        private string _name;
        private string _nationality;
        private int _employeeNumber;

        // static variable belong to class, no individual object has this 

        public static int lastEmployeeNumber;

        // Name property used to get and set the name attribute of an object 

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        // Gender property used to get and set the gender attribute of an object 

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public string Nationality
        {
            get { return _nationality; }
            set {
                if (value == "American")
                {
                    _nationality = "Visa Required ";

                }
                else _nationality = value;
                }
        }

        // HourlyRate property used to get and set the hourly rate attribute of an object 
        // here i am using an auto-implemented property 
        // auto-implemented properties make property-declaration more concise when no 
        // additionallogic is required in the property accessors. When you declare a  
        // property as shown in the following example, the compiler creates a private,  
        // anonymous backing field that can only be accessed through the property's get and 
        // set accessors. 

        public double HourlyRate { get; set; }

        // EmployeeNumber property used to get and set the employee number attribute of an object 

        public int EmployeeNumber
        {
            get
            {
                return this._employeeNumber;
            }
            set
            {
                this._employeeNumber = value;
            }
        }

        // Default construct 

        public Employee()
        {

            lastEmployeeNumber++; // increment the static variable by 1 

            EmployeeNumber = lastEmployeeNumber; // assign to the employee number attribute 

        }

        //parameterised constructor 

        public Employee(string name, string gender, string nationality, double hourlyRate)
        {
            Name = name;
            Gender = gender;
            Nationality = nationality;
            HourlyRate = hourlyRate;
            lastEmployeeNumber++;  // increment the static variable by 1 
            EmployeeNumber = lastEmployeeNumber; // assign to the employee number attribute 
        }

        // Method to print the attributes of an object 

        public override string ToString()
        {
            return "Name: " + Name + " Gender : " + Gender + " Nationality : " + Nationality + " Rate : " + HourlyRate + " Employee # : " + EmployeeNumber + " Tax : " + CalculateTax();
            
        }

        // a=Method to calculate an employees pay, employees work 40 hours 

        public virtual double CalcPay()
        {
            return 40 * HourlyRate;
        }
        public double CalculateTax()
        {
            return CalcPay() * 0.4;

        }
    }
}
