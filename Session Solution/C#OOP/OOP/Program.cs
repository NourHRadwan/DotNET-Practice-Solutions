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

        #region Example 3: Student
        Student student01 = new Student();
        {
            student01.Id = 1;
            student01.Name = "Ahmed";
            student01.Gender = Gender.Male;
            student01.Grade = Grades.A;
            student01.Branch = Branches.Dokki;
        }
        #endregion  

        #region Example 4

        Student std02 = new Student();
        System.Console.WriteLine("Please Enter Student Data: ");

        
        do
        {
            System.Console.Write("Id: ");
            int.TryParse(Console.ReadLine(), out int id);

        }

        #endregion    
         
        #endregion

    }
}
