using EF_Assignment_01.Context;
using EF_Assignment_01.Model;
using Microsoft.EntityFrameworkCore;

namespace EF_Assignment_01
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Insert
            using (var context = new ItiContext())
            {
                var dept = new Department { Name = "CS", HiringDate = DateTime.Now };
                context.Departments.Add(dept);

                var student = new Student { FName = "Ahmed", LName = "Ali", Age = 22, Address = "Cairo", DepId = dept.ID };
                context.Students.Add(student);

                var topic = new Topic { Name = "Programming" };
                var course = new Course { Name = "C# Basics", Duration = 30, Description = "Intro to C#", Topic = topic };
                context.Courses.Add(course);

                var instructor = new Instructor { Name = "Mohamed", Salary = 5000, Bouns = 500, DeptId = dept.ID };
                context.Instructors.Add(instructor);

                // Many-to-Many
                context.Stud_Courses.Add(new Stud_Course { stud_ID = student.ID, Course_ID = course.ID, Grade = 90 });
                context.Course_Insts.Add(new Course_Inst { inst_ID = instructor.ID, Course_ID = course.ID, evaluate = "Excellent" });

                context.SaveChanges();
            }

            #endregion

            #region Select
            using (var context = new ItiContext())
            {
                var students = context.Students.ToList();
                foreach (var s in students)
                {
                    Console.WriteLine($"{s.ID} - {s.FName} {s.LName}");
                }
            }

            #endregion

            #region Update
            using (var context = new ItiContext())
            {
                var student = context.Students.FirstOrDefault(s => s.FName == "Ahmed");
                if (student != null)
                {
                    student.Address = "Alexandria";
                    context.SaveChanges();
                }
            }

            #endregion

            #region Delete
            using (var context = new ItiContext())
            {
                var student = context.Students.FirstOrDefault(s => s.FName == "Ahmed");
                if (student != null)
                {
                    context.Students.Remove(student);
                    context.SaveChanges();
                }
            }

            #endregion

            #region Eager Loading
            using (var context = new ItiContext())
            {
                var studentsWithDept = context.Students
                    .Include(s => s.Department)
                    .Include(s => s.StudCourses)
                        .ThenInclude(sc => sc.Course)
                    .ToList();

                foreach (var s in studentsWithDept)
                {
                    Console.WriteLine($"{s.FName} {s.LName} - Dept: {s.Department?.Name}");
                    foreach (var sc in s.StudCourses)
                    {
                        Console.WriteLine($"   Course: {sc.Course?.Name}, Grade: {sc.Grade}");
                    }
                }
            }

            #endregion

            #region Lazy Loading
            using (var context = new ItiContext())
            {
                var student = context.Students.First();
                Console.WriteLine(student.Department.Name); 
            }

            #endregion
        }
    }
}
