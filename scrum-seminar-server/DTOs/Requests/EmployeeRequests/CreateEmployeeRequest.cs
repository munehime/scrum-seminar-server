using System.ComponentModel.DataAnnotations;

namespace scrum_seminar_server.DTOs.Requests.EmployeeRequests;

public class CreateEmployeeRequest
{
    [Required]
    public string employee_name { get; set; }

    [Required]
    public string request_date { get; set; }

    [Required]
    public string reason { get; set; }

    [Required]
    public long amount { get; set; }
}