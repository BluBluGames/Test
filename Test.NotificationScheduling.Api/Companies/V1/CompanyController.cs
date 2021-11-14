using System;
using System.Threading.Tasks;
using EmployeeManagement.Contracts.V1;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Test.NotificationScheduling.Domain.V1.CompanyAggregate.Commands.Create;
using Test.NotificationScheduling.Domain.V1.CompanyAggregate.Queries;

namespace Test.NotificationScheduling.Api.Companies.V1
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CompanyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(ApiRoutes.CompanyRoutes.Get)]
        public  async Task<IActionResult> Get([FromRoute] Guid companyId)
        {
            var query = new GetCompanyByIdQuery {Id = companyId};
            var result = await _mediator.Send(query);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpPost(ApiRoutes.CompanyRoutes.Create)]
        public async Task<IActionResult> Create([FromBody] CreateCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
