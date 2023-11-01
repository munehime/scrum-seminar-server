using System.Net;

namespace scrum_seminar_server.DTOs.Response;

public class BaseResponse
{
    public int status_code { get; set; }
    public object data { get; set; }

    public void CreateResponse(HttpStatusCode statusCode, Object data)
    {
        status_code = (int)status_code;
        this.data = data;
    }
}