using System;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new SchoolContext())
        {
            // Ensure database is created
            context.Database.EnsureCreated();

            // Create a new student
            var student = new Student
            {
                Name = "John Doe"
            };

            // Add student to context and save
            context.Students.Add(student);
            context.SaveChanges();

            Console.WriteLine("Student added to database.");
        }
    }
}
