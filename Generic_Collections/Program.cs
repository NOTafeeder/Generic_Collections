using Generic_Collections.Models;

namespace Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool result = Check<int>.CheckEqual(5, 5);
            bool result2 = Check<string>.CheckEqual("Hello", "World");
            bool result3 = Check<User>.CheckEqual(new User { Name = "Alice", Age = 30 }, new User { Name = "Bob", Age = 25 });
            Console.WriteLine($"Are the values equal? {result}");
            Console.WriteLine($"Are the values equal? {result2}");
            Console.WriteLine($"Are the values equal? {result3}");

            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            Console.WriteLine($"Number of elements in the list: {numbers.Count}");
            foreach(var number in numbers)
            {
                Console.WriteLine($"Number: {number}");
            }

            List<Employee> employees = new List<Employee>();

            Employee employee1 = new Employee()
            {
                ID = 1,
                Name = "John Doe",
                Salary = 50000.00m
            };
            Employee employee2 = new Employee()
            {
                ID = 2,
                Name = "Jane Smith",
                Salary = 60000.00m
            };
            Employee employee3 = new Employee()
            {
                ID = 3,
                Name = "Omar Hamama",
                Salary = 70000.00m
            };
            
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);

            Console.WriteLine("Employee information:");
            foreach(Employee employee in employees)
            {
                Console.WriteLine($"ID: {employee.ID}, Name: {employee.Name}, Salary: {employee.Salary}");
            }

            bool containsEmployee1 = employees.Contains(employee1);
            Console.WriteLine($"Does the list contain employee1? {containsEmployee1}");
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"ID: {employee.ID}, Name: {employee.Name}, Salary: {employee.Salary}");
            }

            bool result4 = employees.Exists(e => e.Name.StartsWith("J"));
            bool result5 = employees.Exists(em => em.Salary > 55000.00m);
            bool result6 = employees.Exists(e => e.ID == 3);
            Console.WriteLine($"Does the list contain an employee whose name starts with 'J'? {result4}");
            Console.WriteLine($"Does the list contain an employee with a salary greater than 55000.00m? {result5    }");
            Console.WriteLine($"Does the list contain an employee with ID 3? {result6}");

            Employee foundEmployee = employees.Find(e => e.Name.StartsWith("J"));
            Employee foundLastEmployee = employees.FindLast(e => e.Name.StartsWith("J"));
            List<Employee> foundAllEmployee = employees.FindAll(e => e.Salary >= 55000.00m);
            if (foundEmployee != null)
            {
                Console.WriteLine($"Found employee: ID: {foundEmployee.ID}, Name: {foundEmployee.Name}, Salary: {foundEmployee.Salary}");
            }
            if (foundLastEmployee != null)
            {
                Console.WriteLine($"Found last employee: ID: {foundLastEmployee.ID}, Name: {foundLastEmployee.Name}, Salary: {foundLastEmployee.Salary}");
            }
            Console.WriteLine("Found all employees with salary greater than or equal to 55000.00m:");
            foreach (Employee employee in foundAllEmployee)
            {
                Console.WriteLine($"ID: {employee.ID}, Name: {employee.Name}, Salary: {employee.Salary}");
            }

            Console.ReadKey();
        }
    }
}
