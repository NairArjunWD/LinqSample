using System;
using System.Collections.Generic;
using System.Linq;

namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {
            // Func<int, int> square = x => x * x;
            // Func<int, int, int> add = (x, y) => x + y;

            // Console.WriteLine(square(add(3, 5)));

            Func<int, int> square = x => x * x;
            Func<int, int, int> add = (x, y) => 
            {
                int temp = x + y;
                return temp;
            };
            Action<int> write = x => Console.WriteLine(x);

            write(square(add(3, 5)));

            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee { Id = 1, Name = "Scott" },
                new Employee { Id = 2, Name = "Chris" }
            };

            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee { Id = 3, Name = "Alex" } 
            };

            // Console.WriteLine(developers.Count());
            // IEnumerator<Employee> enumerator = developers.GetEnumerator();
            // while (enumerator.MoveNext()) 
            // {
            //     Console.WriteLine(enumerator.Current.Name);
            // }

            foreach (var employee in developers.Where(NameStartsWithS))
            {
                Console.WriteLine(employee.Name);
            }
        }

        private static bool NameStartsWithS(Employee employee)
        {
            return employee.Name.StartsWith("S");
        }
    }
}
