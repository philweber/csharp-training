using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace DatasetDemo
{
    public interface ISchoolRepository
    {
        IEnumerable GetAllStudents();
        Student GetStudent(int id);
        void AddStudent(Student student);
        void UpdateStudent(Student student);

        IEnumerable GetAllInstructors();
        Instructor GetInstructor(int id);
        void AddInstructor(Instructor instructor);
        void UpdateInstructor(Instructor instructor);

        void DeletePerson(int id);

        IEnumerable GetAllCourses();
        IEnumerable GetCoursesByDepartment(int id);
    }
}
