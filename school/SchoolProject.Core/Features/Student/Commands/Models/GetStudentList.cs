using MediatR;
using SchoolProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Student.Commands.Models
{
    public class GetStudentList : IRequest<List<Data.Entities.Student>>
    {

    }
}
