using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace scrum_seminar_server.Models;

[Table("requests")]
public class RequestModel
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long id;

    [Required] public string user;

    [Required] public string request_date;

    [Required] public string description;

    [Required] public long amount;

    [Required] public RequestStatus status;
}

public enum RequestStatus
{
    Cancelled,
    Pending,
    Approved,
}