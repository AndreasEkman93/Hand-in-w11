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
        private StudentDbContext dbContext = new StudentDbContext();

        public bool AddStudent(string firstName, string lastName, string city)
        {
            if (firstName != "" && lastName != "" && city != "")
            {
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
            Student? student = dbContext.Students.SingleOrDefault(s => s.StudentId == id);
            if (student != null)
            {
                switch (choice)
                {
                    case "1":
                        student.FirstName = newInput;
                        dbContext.SaveChanges();
                        return true;
                    case "2":
                        student.LastName = newInput;
                        dbContext.SaveChanges();
                        return true;
                    case "3":
                        student.City = newInput;
                        dbContext.SaveChanges();
                        return true;
                    default:
                        return false;
                }
            }
            return false;
        }
        

        public bool RemoveStudent(int studentId)
        {
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
            return dbContext.Students.ToList();
        }
    }
}
