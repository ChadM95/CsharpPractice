namespace ClassPractice;

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.FirstName = "Chad";
        s1.LastName = "Murphy";

        Student s2 = new Student("Mad","Surphy");

        Student s3 = new Student("Glad","Glurphy","S123");
     

        Console.WriteLine(s1.FirstName + " " + s1.LastName);
        Console.WriteLine(s2.FirstName + " " + s2.LastName);
        Console.WriteLine(s3.FirstName + " " + s3.LastName + " " + s3.StudentID);

        Console.ReadLine();

    }
}

// ----------------------------------------------------------------------------


public class Student
{
    //outline properties up here

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string StudentID { get; set; }


    //constructors

    public Student()
    {

    }

    public Student(string firstName, string lastName) //this is the variable taken in from main method as an argument
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public Student(string firstName, string lastName, string studentID)
    {
        FirstName = firstName;
        LastName = lastName ;
        StudentID = studentID;
    }

}

