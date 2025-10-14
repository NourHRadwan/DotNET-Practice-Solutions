namespace OOP;
using MyClassLibrary;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        #region Access Modifires 

        TypeA typeA = new TypeA();
        //typeA.X = 10; // unaccessible due to protection level
        //typeA.Y = 20; // unaccessible due to protection level
        typeA.Z = 30; // accessible

        #endregion

        #region Enum

        #region Example 1: Gender
            Person person01 = new Person();
            person01.Id = 10;
            person01.Name = "Omar";
        person01.gender = Gender.Male;
        #endregion

        #region Example 2: Days of the week
        Grades grade01 = new Grades();
        grade01 = Grades.A;
        System.Console.WriteLine(grade01);

        if (grade01 == Grades.A || grade01 == Grades.B)
            System.Console.WriteLine("Excellent");
        else
            System.Console.WriteLine(":( Grade");
        #endregion


        #endregion

    }
}
