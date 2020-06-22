﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lesson.Models
{
    public class Assignnment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }

        public virtual ICollection<Student> Student { get; set; }

    }
}