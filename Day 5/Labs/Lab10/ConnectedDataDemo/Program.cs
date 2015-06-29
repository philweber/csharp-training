using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConnectedDataDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectedSchoolRepository dataLayer = new ConnectedSchoolRepository();

            var students = dataLayer.GetAllStudents();
            var student = dataLayer.GetStudent(22);

            student.LastName = "Weber";
            dataLayer.UpdateStudent(student);
        }
    }
}
