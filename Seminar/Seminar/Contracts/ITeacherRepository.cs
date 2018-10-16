using System;
using System.Collections.Generic;
using Seminar.Entities;

namespace Seminar.Contracts
{
    public interface ITeacherRepository
    {
		List<Teacher> Teachers { get; }

		void ReadFromCSV();
    }
}
