using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFrameworkDemo
{
    public interface ISchoolRepository
    {
        IQueryable<Student> GetAllStudents();
        Student GetStudent(int id);
        void AddStudent(Student student);
        void UpdateStudent(Student student);

        IQueryable<Instructor> GetAllInstructors();
        Instructor GetInstructor(int id);
        void AddInstructor(Instructor instructor);
        void UpdateInstructor(Instructor instructor);

        void DeletePerson(int id);

        IQueryable<Course> GetAllCourses();
        IQueryable<Course> GetCoursesByDepartment(int id);
    }
}
