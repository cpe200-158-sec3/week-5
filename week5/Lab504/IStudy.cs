using System;

namespace Lab503
{
	public interface IStudy
	{
		bool add(Course c);
		bool drop(Course c);
		bool resign();
		bool held();
	}
}

