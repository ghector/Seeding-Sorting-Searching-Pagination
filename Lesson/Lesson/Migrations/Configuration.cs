namespace Lesson.Migrations
{
    using Lesson.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Lesson.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Lesson.Models.ApplicationDbContext context)
        {
            Assignnment a1 = new Assignnment() { Title = "C#", StartDate = new DateTime(2020, 5, 5) };
            Assignnment a2 = new Assignnment() { Title = "Java", StartDate = new DateTime(2020, 6, 6) };
            Assignnment a3 = new Assignnment() { Title = "Python", StartDate = new DateTime(2020, 7, 7) };

            School sc1 = new School() { Name = "Empire" };
            School sc2 = new School() { Name = "Oxford" };
            School sc3 = new School() { Name = "MIT" };


            Student s1 = new Student()
            {
                Name = "Hector",
                Age = 33,
                Score = 55,
                Assignnments = new List<Assignnment>() { a1, a2 },
                School = sc1,
                Card = new Card() { Title = "Ab 124"}

            };
            Student s2 = new Student()
            {
                Name = "Makis",
                Age = 28,
                Score = 65,
                Assignnments = new List<Assignnment>() { a2, a3 },
                School = sc2,
                Card = new Card() { Title = "ÂÂ 345" }
            };
            Student s3 = new Student()
            {
                Name = "Mitsos",
                Age = 35,
                Score = 99,
                Assignnments = new List<Assignnment>() { a1, a3 },
                School = sc1,
                Card = new Card() { Title = "AD 345" }
            };
            Student s4 = new Student()
            {
                Name = "Renos",
                Age = 38,
                Score = 75,
                Assignnments = new List<Assignnment>() { a3 },
                School = sc3,
                Card = new Card() { Title = "CC 3455" }
            };

            Student s5 = new Student()
            {
                Name = "Mixalis",
                Age = 22,
                Score = 40,
                Assignnments = new List<Assignnment>() { a1,a2,a3 },
                School = sc3,
                Card = new Card() { Title = "VV 435" }
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
