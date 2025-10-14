using System;
using System.ComponentModel.DataAnnotations;

namespace Entity_Framework.Data.Models;
//EF core 4 ways for mapping classes(DbContext, Model) to database tables (Tables, Views)
//1. By Conventions (Default)



public class Employee
{
    [Key] //Primary Key
    public int id { get; set; } //Public numeric property with name id or Id is treated as primary key by convention 
    //PK [Identity Constraint] start 1 and incement by 1   (Auto Increment)
    public string? Name { get; set; } = null!; //Reference type is nullable by default
    //string? Name { get; set; } = null!; //Name is nullable [optional] and default value is null
    //string Name { get; set; } = null!; //Name is not nullable [required] and default value is null
    public double Salary { get; set; }  //Value type is not nullable by default [required]
    public int? Age { get; set; } //Value type is nullable [optional]

}
