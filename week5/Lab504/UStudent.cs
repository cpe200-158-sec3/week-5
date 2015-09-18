using System;

namespace Lab503
{
	// Undergraduate Student
	public class UStudent: Student, IStudy
	{
		public UStudent ()
		{
		}

		private string studentID;
		public string StudentID {
			get { return studentID; }
			set { 
				if ( base.isStudentID (value) ) {
					string s = value.Substring(4,2);
					int prog_id = Convert.ToInt32 (s);
					if (prog_id<20)
						studentID = value;
					else {
						Console.WriteLine (value + " is NOT StudentID for bachelor student!");

					}

				} else {
					Console.WriteLine (value + "is an invalid StudentID!");
				}
			}
		}

		public bool add(Course c) { return true; }
		public bool drop(Course c) { return true; }
		public bool resign() { return true; }
		public bool held() { return true; }
	}
}

