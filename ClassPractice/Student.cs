using System;
namespace ClassPractice
{
	public class Student
	{
		//properties
		public string StudentName { get; set; } 
		public string StudentNumber { get; set; }
		public int Grade1 { get; set; }
		public int Grade2 { get; set; }
		public int Grade3 { get; set; }


		//constructor
		public Student(string studentName, string studentNumber, int grade1, int grade2, int grade3)
		{
			StudentName = studentName;
			StudentNumber = studentNumber;
			Grade1 = grade1;
			Grade2 = grade2;
			Grade3 = grade3;
		}

        public override string ToString() 
        {
			return StudentName + " " + StudentNumber + " " + Grade1 + " " + Grade2 + " " + Grade3;
        }

        //method within class - Call with ObjectName.DisplayStudent ie s3.DisplayStudent
        public void DisplayStudent()
		{
			Console.WriteLine($"{StudentName} {StudentNumber} {Grade1} {Grade2} {Grade3}");
		} 


	}
}

