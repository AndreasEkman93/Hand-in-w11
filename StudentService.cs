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

        //}
        //public bool ChangeStudentValue()
        //{

        //}
        //public bool DeleteStudent()
        //{

        //}
        public StudentDbContext ListAllStudents()
        {
            return dbContext;
        }
    }
}
