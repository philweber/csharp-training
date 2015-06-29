using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            EntityFrameworkSchoolRepository dataLayer = new EntityFrameworkSchoolRepository();

            var students = dataLayer.GetAllStudents();
            var student = dataLayer.GetStudent(22);

            student.LastName = "Weber";
            dataLayer.UpdateStudent(student);
        }
    }
}
