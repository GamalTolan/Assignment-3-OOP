using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_OOP
{
    public class Teacher
    {
        public string? Name { get; set; }

        public void Teach(Course course)
        {
            Console.WriteLine($"Teach {Name} Teach course{course.Title}");
                
        }
    }
}
