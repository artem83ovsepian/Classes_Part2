// C# program to illustrate the
// Lambda Expression
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Person myObj = new Person();
           // myObj.Name = "Liam";
            Console.WriteLine(myObj.Name);
        }
    }

    class Person
    {
        private string name; // field
        public string Name   // property
        {
             get { var s = name+"pp";  return s; }
            private set { name = value; }
        }
    }
}
