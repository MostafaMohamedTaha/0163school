using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entities;
using SchoolProject.Infrastructure.Abstractes;
using SchoolProject.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Infrastructure.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDBContext _dbcontext;

        public StudentRepository(ApplicationDBContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<List<Student>> GetStudentsListAsync()
        {
            return await _dbcontext.Students.ToListAsync();
        }
    }
}
