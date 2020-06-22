using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Lesson.Models
{
    public class Card
    {
        [ForeignKey("Student")]
        public int Id { get; set; }
        public string Title { get; set; }

        public virtual Student Student { get; set; }



    }
}