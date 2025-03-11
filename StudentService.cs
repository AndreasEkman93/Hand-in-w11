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

        //public bool AddStudent()
        //{

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
