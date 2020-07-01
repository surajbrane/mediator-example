using MediatorExample.Api.Common;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MediatorExample.Api.Features.Employee.GetAll
{
    public class Query : QueryBase, IRequest<IActionResult>
    {
        [FromRoute]
        public int DepartmentId { get; set; }
    }
}
