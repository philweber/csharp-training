using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DatasetDemo.SchoolDataSetTableAdapters;

namespace DatasetDemo
{
    class DatasetSchoolRepository : ISchoolRepository
    {
        public System.Collections.IEnumerable GetAllStudents()
        {
            var studentTableAdapter = new StudentTableAdapter();
            return studentTableAdapter.GetAllStudents();
        }

        public SchoolDataSet.StudentRow GetStudent(int id)
        {
            var studentTableAdapter = new StudentTableAdapter();
            return studentTableAdapter.GetStudentById(id).First();
        }

        public void AddStudent(SchoolDataSet.StudentRow student)
        {
            throw new NotImplementedException();
        }

        public void UpdateStudent(SchoolDataSet.StudentRow student)
        {
            var studentTableAdapter = new StudentTableAdapter();
            studentTableAdapter.UpdateStudent(
                student.PersonID,
                student.LastName,
                student.FirstName,
                student.EnrollmentDate
            );
        }

        public System.Collections.IEnumerable GetAllInstructors()
        {
            throw new NotImplementedException();
        }

        public SchoolDataSet.InstructorRow GetInstructor(int id)
        {
            throw new NotImplementedException();
        }

        public void AddInstructor(SchoolDataSet.InstructorRow instructor)
        {
            throw new NotImplementedException();
        }

        public void UpdateInstructor(SchoolDataSet.InstructorRow instructor)
        {
            throw new NotImplementedException();
        }

        public void DeletePerson(int id)
        {
            throw new NotImplementedException();
        }

        public System.Collections.IEnumerable GetAllCourses()
        {
            throw new NotImplementedException();
        }

        public System.Collections.IEnumerable GetCoursesByDepartment(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public SchoolDataSet.StudentRow CreateStudentObject()
        {
            throw new NotImplementedException();
        }

        public SchoolDataSet.InstructorRow CreateInstructorObject()
        {
            throw new NotImplementedException();
        }

        public SchoolDataSet.CourseRow CreateCourseObject()
        {
            throw new NotImplementedException();
        }
    }
}
