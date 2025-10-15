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
        // Id
        

        bool IsParsed = false;
        int stdId;
        do
        {
            System.Console.Write("Id: "); 
            
            IsParsed = int.TryParse(Console.ReadLine(), out stdId);
        } while (!IsParsed);
        std02.Id = stdId;

        // Name
        Console.Write("Name: ");
        std02.Name = Console.ReadLine();

        // Gender
        Gender StdGender;

        do
        {
            Console.Write("Gender: ");
            IsParsed = Enum.TryParse<Gender>(Console.ReadLine(), out StdGender);
        } while (!IsParsed);
        std02.Gender = StdGender;

        // Grade
        Grades StdGrade;
        
        do
        {
            Console.Write("Grades: ");
            IsParsed = Enum.TryParse<Grades>(Console.ReadLine(), out StdGrade);
        }while(!IsParsed);
        std02.Grade = StdGrade;

        // Branch
        Branches StdBranch;
      
        do
        {
            Console.Write("Branch: ");
            IsParsed = Enum.TryParse<Branches>(Console.ReadLine(), out StdBranch);
        } while (!IsParsed);
        std02.Branch = StdBranch;

        Console.Clear();

        System.Console.WriteLine("Hell {std02.Name}: ");
        System.Console.WriteLine($"Your Id is: {std02.Id} and\nYour Gender is: {std02.Gender},\nYour Grade is {std02.Grade}");
        System.Console.WriteLine($"Branch: {std02.Branch}");

        #endregion

        #endregion
}
}

