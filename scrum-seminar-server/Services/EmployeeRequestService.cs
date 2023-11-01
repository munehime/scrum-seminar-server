using scrum_seminar_server.DTOs;
using scrum_seminar_server.DTOs.Requests.EmployeeRequests;
using scrum_seminar_server.DTOs.Response;
using scrum_seminar_server.Models;

namespace scrum_seminar_server.Services;

public class EmployeeRequestService : IEmployeeRequestService
{
    private readonly ApplicationDbContext ctx;

    public EmployeeRequestService(ApplicationDbContext applicationDbContext)
    {
        ctx = applicationDbContext;
    }

    // public BaseResponse GetRequests()
    // {
    //     try
    //     {
    //         List<EmployeeRequestDTO> requests = new List<EmployeeRequestDTO>();
    //
    //         using (ctx)
    //         {
    //             ctx.Requests.ToList().ForEach((request) => requests.Add(new EmployeeRequestDTO
    //             {
    //                 id = request.id,
    //                 user = request.user,
    //                 request_date = request.request_date,
    //                 description = request.description,
    //                 amount = request.amount,
    //                 status = (int)request.status
    //             }));
    //         }
    //
    //         BaseResponse response = new BaseResponse
    //         {
    //             status_code = StatusCodes.Status200OK,
    //             data = new { requests }
    //         };
    //
    //         return response;
    //     }
    //     catch (Exception e)
    //     {
    //         Console.WriteLine(e);
    //         throw;
    //     }
    // }

    public BaseResponse SendRequest(CreateEmployeeRequest request)
    {
        try
        {
            RequestModel newRequest = new RequestModel();
            newRequest.user = request.employee_name;
            newRequest.description = request.reason;
            newRequest.request_date = request.request_date;
            newRequest.amount = request.amount;

            using (ctx)
            {
                ctx.Add(newRequest);
                ctx.SaveChanges();
            }

            BaseResponse response = new BaseResponse
            {
                status_code = (int)StatusCodes.Status201Created,
                data = new { message = "Successfully send the new request" }
            };

            return response;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}