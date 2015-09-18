using System;

namespace Lab503
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
		}

		public static void testCourse() {
			/* Testing the Course class */
			Course cpe200 = new Course ("Object-Oriented Programming", "261300");
			Course isne103 = new Course ("Programming Language for ISNE", "269103", "DOME");
			Course cpe453 = new Course ("DIP", "261105", "Dr. Kenneth Cosh", 60);

			Console.WriteLine ("\n--- Initial Courses state ---");
			Console.WriteLine (cpe200);
			Console.WriteLine (isne103);
			Console.WriteLine (cpe453);

			/* playing with cpe200 object */
			Console.WriteLine ("\n--- playing with cpe200 object ---");
			cpe200.CourseID = "261200";
			Console.WriteLine (cpe200);
			cpe200.CourseID = "2612OO";
			cpe200.CourseID = "2612002";

			/* playing with Max #students and current #students */
			cpe200.NumStudents = 40;
			Console.WriteLine (cpe200);
			cpe200.MaxStudents = 60;
			Console.WriteLine (cpe200);
			cpe200.NumStudents = 40;
			Console.WriteLine (cpe200);
			cpe200.MaxStudents = 35;
			cpe200.MaxStudents = 40;
			Console.WriteLine (cpe200);

			/* playing with cpe453 object */
			Console.WriteLine ("\n--- playing with cpe453 object ---");
			cpe453.Name = "Digital Image Processing";
			cpe453.CourseID = "261453";
			cpe453.Lecturer = "Sansanee";
			cpe453.MaxStudents = 20;
			Console.WriteLine (cpe453);
		}

		public static void testStudent() {
			/* Testing the Student class */
			Student[] stds = new Student[7];
			stds[0] = new Student ();
			stds[1] = new Student ("s1","57001");
			stds[2] = new Student ("s2","57002",1994);
			stds[3] = new Student ("s3","57003",1996);
			stds[4] = new Student ("s4","57004");
			stds[5] = new Student ("s5","57005",1993);
			stds[6] = new Student ("s6","57006");

			Console.WriteLine ("\n--- Initial Students' state ---");
			foreach (Student s in stds)
				Console.WriteLine (s);

			Console.WriteLine ("\n--- Playing with s4, s5, s6 objects ---");
			stds [4].Name = "Mario";
			stds [5].YearOfBirth = 1900;
			stds [6].isActive = false;
			for (int i = 4; i < stds.Length; i++)
				Console.WriteLine (stds [i]);
		}
	}
}
