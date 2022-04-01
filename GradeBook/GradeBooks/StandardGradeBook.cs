using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public new string name { get; set; }

        public StandardGradeBook(string name, bool isWeighted) : base(name, isWeighted)
        {
            this.name = name;
            Type = GradeBookType.Standard;
        }
       
    }
}
