using System;

namespace OOP;

internal class Person
{
    public int Id { get; set; }
    public string? Name { get; set; }
    //public string Gender { get; set; }

    public Gender gender { get; set; }
}
