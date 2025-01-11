using MediatR;
using SchoolProject.Core.Features.Student.Commands.Models;
using SchoolProject.Core.Features.Student.Queries.Models;
using SchoolProject.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Student.Commands.Handler
{
    public class StudentHandler : IRequestHandler<GetStudentListQuery, List<Data.Entities.Student>>
    {
        private readonly IStudentService _studentService;

        public StudentHandler(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public async Task<List<Data.Entities.Student>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            return await _studentService.GetStudentsListAsync();
        }
    }
}
