using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Hand_in_w11
{
    internal class StudentService
    {

        public bool AddStudent(string firstName, string lastName, string city)
        {
            if (firstName != "" && lastName != "" && city != "")
            {
                using var dbContext = new StudentDbContext();
                dbContext.Add(new Student { FirstName = firstName, LastName = lastName, City = city });
                dbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ChangeStudentValue(string choice, string newInput, int id)
        {
            if (string.IsNullOrEmpty(newInput))
            {
                return false;
            }
            using var dbContext = new StudentDbContext();
            var student = dbContext.Students.SingleOrDefault(s => s.StudentId == id);

            if (student == null)
            {
                return false;
            }
                switch (choice)
                {
                    case "1":
                        student.FirstName = newInput;
                    break;
                    case "2":
                        student.LastName = newInput;
                    break;
                    case "3":
                        student.City = newInput;
                    break;
                    default:
                        return false;
                }
            dbContext.SaveChanges();
            return true;
        }


        public bool RemoveStudent(int studentId)
        {
            using var dbContext = new StudentDbContext();
            Student? student = dbContext.Students.SingleOrDefault(s => s.StudentId == studentId);
            if (student != null)
            {
                dbContext.Students.Remove(student);
                dbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<Student> ListAllStudents()
        {
            using var dbContext = new StudentDbContext();
            return dbContext.Students.ToList();
        }
        public bool StudentExist(int studentId)
        {
            using var dbContext = new StudentDbContext();
            return(dbContext.Students.Any(s => s.StudentId == studentId));
        }
    }
}
