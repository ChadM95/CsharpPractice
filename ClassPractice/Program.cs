namespace ClassPractice;

class Program
{
    static void Main(string[] args)
    {

        Student s1 = new Student("Chad","Murphy");

        Console.WriteLine(s1.FirstName + " " + s1.LastName);
        Console.ReadLine();

    }
}

// ----------------------------------------------------------------------------


public class Student
{
    //outline properties up here

    public string FirstName { get; set; }
    public string LastName { get; set; }



    //constructor

    public Student(string firstName, string lastName) //this is the variable taken in from main method as an argument
    {
        FirstName = firstName;
        LastName = lastName;
    }

}

