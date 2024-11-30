using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Entities
{
    //EFCore Supports 4 ways for mapping classes to Database [Tables | View]
    // 1. By Convention (Default Mapping)


    //Entity => Class represent a table in Database , Domain Model, Model
    // POCO - Plain Old CLR Object =>  Class that has only Properties no methods

    internal class Employee
    {
        public int Id { get; set; }
        public  string Name { get; set; }

        public decimal Salary { get; set; }

        public int? Age { get; set; }
    }
}
