using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using scrum_seminar_server.DTOs.Requests.EmployeeRequests;
using scrum_seminar_server.DTOs.Response;
using scrum_seminar_server.Services;

namespace scrum_seminar_server.Controllers;

[Route("api/employee/request")]
[ApiController]
public class RequestsController : ControllerBase
{
    private readonly IEmployeeRequestService _employeeRequestService;

    public RequestsController(IEmployeeRequestService employeeRequestService)
    {
        this._employeeRequestService = employeeRequestService;
    }

    [HttpPost("")]
    public BaseResponse SendRequest(CreateEmployeeRequest request)
    {
        return _employeeRequestService.SendRequest(request);
    }
}