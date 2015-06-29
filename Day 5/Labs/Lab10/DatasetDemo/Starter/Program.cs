using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatasetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DatasetSchoolRepository dataLayer = new DatasetSchoolRepository();

            var students = dataLayer.GetAllStudents();
            var student = dataLayer.GetStudent(22);

            student.LastName = "Weber";
            dataLayer.UpdateStudent(student);
        }
    }
}
