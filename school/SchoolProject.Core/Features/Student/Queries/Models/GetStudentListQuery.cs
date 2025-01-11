using MediatR;
using SchoolProject.Core.Features.Student.Queries.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Student.Queries.Models
{
    public class GetStudentListQuery : IRequest<List<GetStudentListResponse>>
    {
        public GetStudentListQuery()
        {

        }
    }
}
