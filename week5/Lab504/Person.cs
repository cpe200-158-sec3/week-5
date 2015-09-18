using System;

namespace Lab503
{
	public abstract class Person
	{
		private string name;
		public string Name {
			get { return name; }
			set { name = value; }
		}

		public abstract int YearOfBirth { get; set; }

		public bool isActive { get;	set; }

		public Person ()
		{
			name = "John Doe";
			isActive = true;
		}

		public Person(string n) {
			name = n;
		}

		public Person(string n, bool active) {
			name = n;
			isActive = active;
		}

		public virtual int getAge() { 
			DateTime today = DateTime.Today;
			int year = today.Year;
			return year-YearOfBirth;
		}
	}
}

