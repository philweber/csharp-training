using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace DatasetDemo
{
    public interface ISchoolRepository
    {
        IEnumerable GetAllStudents();
        SchoolDataSet.StudentRow GetStudent(int id);
        void AddStudent(SchoolDataSet.StudentRow student);
        void UpdateStudent(SchoolDataSet.StudentRow student);

        IEnumerable GetAllInstructors();
        SchoolDataSet.InstructorRow GetInstructor(int id);
        void AddInstructor(SchoolDataSet.InstructorRow instructor);
        void UpdateInstructor(SchoolDataSet.InstructorRow instructor);

        void DeletePerson(int id);

        IEnumerable GetAllCourses();
        IEnumerable GetCoursesByDepartment(int id);
    }
}
