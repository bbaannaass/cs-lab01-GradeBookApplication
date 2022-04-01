using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public new string name { get; set; }

        public RankedGradeBook ( string name) : base(name)
        {
            this.name = name;
            Type = GradeBookType.Ranked;
        }
        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                throw new InvalidOperationException("You must have at least 5 students to do ranked grading.");
            }

            var calculateStudents = (int)Math.Ceiling(Students.Count * 0.2);
            var grades = Students.OrderByDescending(e => e.AverageGrade).Select(e => e.AverageGrade).ToList();

            if (averageGrade >= grades[calculateStudents - 1])
                return 'A';
            if (averageGrade >= grades[(calculateStudents * 2) - 1])
                return 'B';
            if (averageGrade >= grades[(calculateStudents * 3) - 1])
                return 'C';
            if (averageGrade >= grades[(calculateStudents * 4) - 1])
                return 'D';
            return 'F';
        }

    }
}
