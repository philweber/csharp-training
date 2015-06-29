using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ConnectedDataDemo
{
    class ConnectedSchoolRepository : ISchoolRepository
    {
        private string connectionString;

        public ConnectedSchoolRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["schoolConnectionString"].ToString();
        }

        public IEnumerable<Student> GetAllStudents()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string commandText =
                    @"SELECT PersonID, LastName, FirstName, EnrollmentDate 
                      FROM Person WHERE EnrollmentDate IS NOT NULL";

                SqlCommand command = new SqlCommand(commandText, connection);
                connection.Open();

                return GetStudentsFromCommand(command);
            }
        }

        public Student GetStudent(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string commandText =
                    @"SELECT PersonID, LastName, FirstName, EnrollmentDate 
                      FROM Person WHERE EnrollmentDate IS NOT NULL
                      AND PersonID = @id";

                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.Add(
                    new SqlParameter()
                    {
                        ParameterName = "id",
                        DbType = DbType.Int32,
                        Value = id
                    }
                );
                connection.Open();

                return GetStudentsFromCommand(command).First();
            }
        }

        private List<Student> GetStudentsFromCommand(SqlCommand command)
        {
            List<Student> studentList = new List<Student>();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Student student = new Student()
                    {
                        ID = (int)reader["PersonID"],
                        LastName = (string)reader["LastName"],
                        FirstName = (string)reader["FirstName"],
                        EnrollmentDate = (DateTime)reader["EnrollmentDate"]
                    };
                    studentList.Add(student);
                }
            }

            return studentList;
        }

        public void AddStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public void UpdateStudent(Student student)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string commandText =
                    @"exec UpdateStudent @PersonID, @LastName, @FirstName, @EnrollmentDate";

                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.Add(
                    new SqlParameter()
                    {
                        ParameterName = "@PersonID",
                        DbType = DbType.Int32,
                        Value = student.ID
                    }
                );
                command.Parameters.Add(
                    new SqlParameter()
                    {
                        ParameterName = "@LastName",
                        DbType = DbType.String,
                        Value = student.LastName
                    }
                );
                command.Parameters.Add(
                    new SqlParameter()
                    {
                        ParameterName = "@FirstName",
                        DbType = DbType.String,
                        Value = student.FirstName
                    }
                );
                command.Parameters.Add(
                    new SqlParameter()
                    {
                        ParameterName = "@EnrollmentDate",
                        DbType = DbType.DateTime,
                        Value = student.EnrollmentDate
                    }
                );
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<Instructor> GetAllInstructors()
        {
            throw new NotImplementedException();
        }

        public Instructor GetInstructor(int id)
        {
            throw new NotImplementedException();
        }

        public void AddInstructor(Instructor instructor)
        {
            throw new NotImplementedException();
        }

        public void UpdateInstructor(Instructor instructor)
        {
            throw new NotImplementedException();
        }

        public void DeletePerson(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetAllCourses()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetCoursesByDepartment(int id)
        {
            throw new NotImplementedException();
        }
    }
}
