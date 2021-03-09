using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee s1 = new Employee() { Name = "John Doe", Age = 21 };
            Employee s2 = new Employee() { Name = "Maria Doe", Age = 24 };
            Employee s3 = new Employee() { Name = "David Evans", Age = 32 };
            Employee s4 = new Employee() { Name = "David Doe", Age = 26 };

            Project p1 = new Project() { Title = "Weekly Report" };
            Project p2 = new Project() { Title = "Website Rebuild" };
            Project p3 = new Project() { Title = "Logo Ideas" };

            //assign to each student a project and to each project a student

            s1.Project = p1;
            p1.Employee = s1;

            s2.Project= p2;
            p2.Employee = s2;

            s3.Project = p3;
            p3.Employee = s3;

            List<Employee> employees = new List<Employee>() { s1, s2, s3, s4 };

            List<Project> projects = new List<Project>() { p1, p2, p3 };

            Console.WriteLine();
            Console.WriteLine("Projects PER Emloyees");
            Console.WriteLine();

            foreach (var employee in employees)
            {
                if (!(employee.Project is null))
                {
                    Console.WriteLine($"{employee.Name,-15} {employee.Project.Title,-10}");
                }
                else
                {
                    Console.WriteLine($"{employee.Name,-15} No projects assigned");
                }
            }

            Console.WriteLine("=========================");
            Console.WriteLine();
            Console.WriteLine("Employees PER Project");
            Console.WriteLine();

            foreach (var project in projects)
            {
                Console.WriteLine($"{project.Title,-20} {project.Employee.Name, -15} {project.Employee.Age, -5}");
            }
        }
    }
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Project Project { get; set; }
    }
    class Project
    {
        public string Title { get; set; }
        public Employee Employee { get; set; }
    }
}
