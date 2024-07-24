using System.Configuration;
using WebApplication4.Models;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;

namespace WebApplication4.Repository

{
    public class StudentRespository
    {

        public IConfiguration Configuration { get; }

        public StudentRespository()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: false, reloadOnChange: true); Configuration = builder.Build();
        }

        public string connection()
        {
            var k= Configuration["ConnectionStrings:DefaultConnection"];
            return Configuration["ConnectionStrings:DefaultConnection"];

        }


        public List<SUB> GetAllStudent()
        {



            List<SUB> students = new List<SUB>();
            using (SqlConnection CON = new SqlConnection(connection()))
            {
                SqlCommand cmd = new SqlCommand("sp_GetStudentList", CON);
                cmd.CommandType = CommandType.StoredProcedure;
                CON.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    SUB student = new SUB();
                    student.StudentId = Convert.ToInt16(reader["StudentId"].ToString());
                    student.Name = reader["Name"].ToString();
                    student.Department = reader["Department"].ToString();
                    student.Gender = reader["Gender"].ToString();
                    student.DateOfBirth = reader["DateOfBirth"].ToString();
                    student.YearOfJoining = reader["YearOfJoining"].ToString();
                    students.Add(student);
                }

                CON.Close();
            }


            return students;
        }



    }
}
