namespace Lesson.Migrations
{
    using Lesson.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Lesson.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Lesson.Models.ApplicationDbContext context)
        {
            Student s1 = new Student()
            {
                Name = "Hector",
                Age = 33,
                Score = 55
            };
            Student s2 = new Student()
            {
                Name = "Makis",
                Age = 28,
                Score = 65
            };
            Student s3 = new Student()
            {
                Name = "Mitsos",
                Age = 35,
                Score = 99
            };
            Student s4 = new Student()
            {
                Name = "Renos",
                Age = 38,
                Score = 75
            };

            Student s5 = new Student()
            {
                Name = "Mixalis",
                Age = 22,
                Score = 40
            };

            //Problem with dublicates
            //context.Students.Add(s1);
            //context.Students.Add(s2);
            //context.Students.Add(s3);

            //context.SaveChanges();


            //Upsert Operation (Update or Insert)
            context.Students.AddOrUpdate(x => x.Name, s1, s2, s3, s4, s5);

            //An thelo na kano sindiasmo dio parametron
            //context.Students.AddOrUpdate(x => new { x.Name, x.Score }, s1, s2, s3, s4, s5);

            context.SaveChanges();


        }
    }
}
