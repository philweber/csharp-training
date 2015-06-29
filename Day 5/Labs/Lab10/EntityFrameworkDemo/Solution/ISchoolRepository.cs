using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFrameworkDemo
{
    public interface ISchoolRepository
    {
        IQueryable<Person> GetAllStudents();
        Person GetStudent(int id);
        void AddStudent(Person student);
        void UpdateStudent(Person student);

        IQueryable<Person> GetAllInstructors();
        Person GetInstructor(int id);
        void AddInstructor(Person instructor);
        void UpdateInstructor(Person instructor);

        void DeletePerson(int id);

        IQueryable<Course> GetAllCourses();
        IQueryable<Course> GetCoursesByDepartment(int id);
    }
}
