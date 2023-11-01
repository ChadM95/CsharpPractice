namespace ClassPractice;

class Program
{
    static void Main(string[] args)
    {
        /* Long way of populating an object
          
        Student Student1 = new Student();

        Student1.StudentName = "John";
        Student1.StudentNumber = "S123456";
        Student1.Grade1 = 45;
        Student1.Grade2 = 65;
        Student1.Grade3 = 73;

        Console.WriteLine(Student1);
        */


        Student s2 = new Student("John","S123",45,55,65);



        Console.WriteLine($"{s2.StudentName} {s2.StudentNumber} {s2.Grade1} {s2.Grade2} {s2.Grade3}");
        Console.ReadLine();
    }
}

