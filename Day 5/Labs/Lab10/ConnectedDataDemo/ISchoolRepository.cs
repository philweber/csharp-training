using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConnectedDataDemo
{
    public interface ISchoolRepository
    {
        IEnumerable<Student> GetAllStudents();
        Student GetStudent(int id);
        void AddStudent(Student student);
        void UpdateStudent(Student student);

        IEnumerable<Instructor> GetAllInstructors();
        Instructor GetInstructor(int id);
        void AddInstructor(Instructor instructor);
        void UpdateInstructor(Instructor instructor);

        void DeletePerson(int id);

        IEnumerable<Course> GetAllCourses();
        IEnumerable<Course> GetCoursesByDepartment(int id);
    }

    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }

    public class Instructor
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime HireDate { get; set; }
    }

    public class Course
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
        public int Credits { get; set; }
    }
}
