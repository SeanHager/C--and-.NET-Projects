using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace StudentProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            using(var db=new GradeContext())
            {
                //create and save a new dB instance response from user
                Console.WriteLine("Please enter your current high-school or college grade level: ");
                var level = (Console.ReadLine());

                var grade = new Grade { gradeLevel = level };
                db.Grades.Add(grade);
                db.SaveChanges();

                //populate dB with new Student information based on prior user input
                var newStud = new Student { Name = "Sean", GPA = 3.2, Id = 10, gradeLevel = level };
                db.Students.Add(newStud);
                db.SaveChanges();

                //query dB to see changes in console
                //var query = from g in db.Grades
                //            orderby g.gradeLevel
                //            select g;
                //foreach(var item in query)
                //{
                //    Console.WriteLine("You currenty have: " + item.gradeLevel + "in the dB.");
                //}

                Console.WriteLine("Thank you. Your response is recorded into our database. Press any key to exit.");
                Console.ReadKey();

            }
                     
        }
    }

    public class Grade
    {
        [Key]
        public string gradeLevel { get; set; }
        public string Url { get; set; }

        public virtual List<Student> Students { get; set; }

    }

    public class Student
    {
        public string Name { get; set; }
        public double GPA { get; set; }
        public int Id { get; set; }

        public string gradeLevel { get; set; }
        public virtual Grade Grade { get; set; }

    }

    public class GradeContext : DbContext
    {
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
