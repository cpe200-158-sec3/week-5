using System;
using System.Collections.Generic;

namespace Lab503
{
	public class Course
	{
		List<Student> students;
		List<ITeach> staffs;

		string courseID;	// bachelor: 2611xx-2614xx, master: 2617xx, doctoral: 2618xx
		int maxStudents;
		int numStudents;

		public string Name {
			get;
			set;
		}
		public string CourseID {
			get { return courseID; }
			set { 
				int n;
				if (value.Length==6 && int.TryParse (value, out n))
					courseID = value;
				else {
					Console.WriteLine (value + " is an invalid CourseID!");
				}
			}
		}
		public string Lecturer {
			get;
			set;
		}
		public int MaxStudents {
			get { return maxStudents; }
			set { 
				if (value>0 && value<=80 && value>=numStudents) {
					maxStudents = value;
				} else {
					Console.WriteLine (CourseID + ": error try setting invalid Max No. Students!");
				}
			}
		}
		public int NumStudents {
			get { return numStudents; }
			set { 
				if (value>=0 && value<=maxStudents) {
					numStudents = value;
				} else {
					Console.WriteLine (CourseID + ": error try setting invalid No. Students!");
				}
			}
		}

		private void initData() {
			Name = "";
			CourseID = "000000";
			Lecturer = "staff";
			MaxStudents = 30;
			NumStudents = 0;

			students = new List<IStudy>();
			staffs = new List<ITeach>();
		}

		public Course ()
		{
			initData ();
		}

		public Course(string n, string id){
			initData ();
			Name = n;
			CourseID = id;
		}

		public Course(string n, string id, string t){
			initData ();
			Name = n;
			CourseID = id;
			Lecturer = t;
		}

		public Course(string n, string id, string t,int m){
			initData ();
			Name = n;
			CourseID = id;
			Lecturer = t;
			MaxStudents = m;
		}

		public bool addStudent(Student s) {
			if (numStudents < maxStudents) {
				if ( !students.Contains (s) ) {
					students.Add (s);
					numStudents++;
					Console.WriteLine (s.StudentID + " has been registered to " + this.CourseID);
					return true;
				}
				Console.WriteLine ("ERROR: " + s.StudentID + " has already been registered to " + this.CourseID);
				return false;
			}
			Console.WriteLine ("ERROR: " + s.StudentID + " cannot be added in " + this.CourseID + ", course is full.");
			return false;
		}


		public bool removeStudent(Student s) {
			if (numStudents > 0) {
				if ( students.Contains (s) ) {
					students.Remove (s);
					numStudents--;
					Console.WriteLine (s.StudentID + " has been removed from " + this.CourseID);
					return true;
				}
				Console.WriteLine ("ERROR: " + s.StudentID + " has NOT been register to " + this.CourseID);
				return false;
			}
			Console.WriteLine ("ERROR: " + s.StudentID + " cannot be remove from " + this.CourseID + ", course is empty.");
			return false;
		}


		public override string ToString ()
		{
			return string.Format ("[Course: {0} ({1}), Lecturer={2}, has {4} students, max={3}]", Name, CourseID, Lecturer, MaxStudents, NumStudents);
		}
	}
}

