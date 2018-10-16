using System;
using System.IO;
using System.Collections.Generic;
using Seminar.Contracts;
using Seminar.Entities;
using System.Text;
using System.Linq;

namespace Seminar.Persistence
{
	public class TeacherRepository : ITeacherRepository
	{
		public TeacherRepository()
		{
		}

		public List<Teacher> Teachers
		{
			get;
		} = new List<Teacher>();

		public void ReadFromCSV()
		{
			var lines = File.ReadAllLines("Teachers.csv", Encoding.UTF8);
			Teachers.AddRange(lines.Skip(1)
				 .Select(oneLine => oneLine.Split(';'))
				 .Select(data => new Teacher()
				 {
					 Name = data[0],
					 Day = data[1],
					 Hour = data[2],
					 Room = data[4]
				 }));
		}
	}
}
