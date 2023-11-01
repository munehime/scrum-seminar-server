using scrum_seminar_server.DTOs.Requests.EmployeeRequests;
using scrum_seminar_server.DTOs.Response;

namespace scrum_seminar_server.Services;

public interface IEmployeeRequestService
{
    BaseResponse SendRequest(CreateEmployeeRequest request);
}