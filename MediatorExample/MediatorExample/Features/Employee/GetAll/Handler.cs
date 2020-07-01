using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatorExample.Api.Common;
using MediatorExample.Api.Features.Employee.GetAll.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MediatorExample.Api.Features.Employee.GetAll
{
    public class Handler : IRequestHandler<Query, IActionResult>
    {
        public async Task<IActionResult> Handle(Query request, CancellationToken cancellationToken)
        {
            var result = new List<EmployeeModel>
            {
                new EmployeeModel { EmployeeId = 1, FirstName = "Abhay", LastName = "Patil"  },
                   new EmployeeModel { EmployeeId = 2, FirstName = "Seema", LastName = "M"  }
            };

            return this.Ok(await Task.FromResult(result).ConfigureAwait(false));
        }
    }
}
