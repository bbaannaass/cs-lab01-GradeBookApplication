using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public new string name { get; set; }

        public RankedGradeBook ( string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }
        
    }
}
