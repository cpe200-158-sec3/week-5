using System;

namespace Lab503
{
	public abstract class Student: Person
	{
		private int yob;
		public int YearOfBirth {
			get { return yob; }
			set {
				if (value < 1950 || value>2000) {
					Console.WriteLine (StudentID + ": error try setting invalid year-of-birth value!");
				} else {
					yob = value;
				}
			}
		}

		public abstract string StudentID {	// bachelor: 57061xyyy, master: 57062xyyy, doctoral: 57063xyyy
			get;
			set;
		}
		protected bool isStudentID(string s) {
			int n;
			return (value.Length==9 && int.TryParse (value, out n));
		}

		private enum Status {Studying, Graduated, Hold, Retired};
		Status status;

		private void initData() {
			StudentID = "Unknown";
			YearOfBirth = 1995;
			status = Status.Studying;

		}

		public Student (): base()
		{
			initData ();
			isActive = false;
			status = Status.Hold;
		}

		public Student (string n,string id): base(n)
		{
			initData ();
			StudentID = id;
		}

		public Student (string n,string id,int y): base(n)
		{
			initData ();
			StudentID = id;
			YearOfBirth = y;
		}

		public Student (string n,string id,int y,bool active): base(n,active)
		{
			initData ();
			StudentID = id;
			YearOfBirth = y;
		}

//		public int getAge() { 
//			DateTime today = DateTime.Today;
//			int year = today.Year;
//			return year-YearOfBirth;
//		}

		/* overloading the '==', '!=', Equals operators */
		public static bool operator ==(Student a, Student b) {
			return (a.StudentID==b.StudentID);
		}
		public static bool operator !=(Student a, Student b) {
			return (a.StudentID!=b.StudentID);
		}
		public override bool Equals (object obj)
		{
			Student b = (Student)obj;
			return (this.StudentID==b.StudentID);
		}

		public override string ToString ()
		{
			String s = string.Format ("[Student: {0} ({1}), age={2}, ", Name, StudentID, getAge());
			s += isActive ? "is active student]" : "is NOT active student]";
			return s;
		}
	}
}

