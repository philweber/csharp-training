using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFrameworkDemo
{
    class EntityFrameworkSchoolRepository : ISchoolRepository
    {
        SchoolEntities db = new SchoolEntities(); 

        public IQueryable<Person> GetAllStudents()
        {
            return from person in db.People
                   where person.EnrollmentDate != null
                   select person;
        }

        public Person GetStudent(int id)
        {
            return (from person in db.People
                    where (person.EnrollmentDate != null && person.PersonID == id)
                    select person).First();
        }

        public void AddStudent(Person student)
        {
            throw new NotImplementedException();
        }

        public void UpdateStudent(Person student)
        {
            Person toUpdate = GetStudent(student.PersonID);
            toUpdate.LastName = student.LastName;
            toUpdate.FirstName = student.FirstName;
            toUpdate.EnrollmentDate = student.EnrollmentDate;
            db.SaveChanges();
        }

        public IQueryable<Person> GetAllInstructors()
        {
            throw new NotImplementedException();
        }

        public Person GetInstructor(int id)
        {
            throw new NotImplementedException();
        }

        public void AddInstructor(Person instructor)
        {
            throw new NotImplementedException();
        }

        public void UpdateInstructor(Person instructor)
        {
            throw new NotImplementedException();
        }

        public void DeletePerson(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Course> GetAllCourses()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Course> GetCoursesByDepartment(int id)
        {
            throw new NotImplementedException();
        }
    }
}
