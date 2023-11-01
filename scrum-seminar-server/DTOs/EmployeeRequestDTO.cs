using System.ComponentModel.DataAnnotations;

namespace scrum_seminar_server.DTOs;

public class EmployeeRequestDTO
{
    [Required] public long id;

    [Required] public string user;

    [Required] public string request_date;

    [Required] public string description;

    [Required] public long amount;

    [Required] public int status;
}
