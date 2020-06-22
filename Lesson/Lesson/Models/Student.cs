using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lesson.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set;}
        public int Age { get; set; }
        public int Score { get; set; }

        public virtual School School { get; set; }
        public virtual ICollection<Assignnment> Assignnments { get; set; }
        public virtual Card Card { get; set; }

    }
}