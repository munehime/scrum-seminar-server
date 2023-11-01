using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace scrum_seminar_server.Models;

[Table("users")]
public class UserModel
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long id;

    [Required] public string username;

    [Required] public string password;

    [Required] public string fisrt_name;

    [Required] public string last_name;

    [Required] public string email;

    [Required] public string address;

    [Required] public string phone_number;

    [Required] public string gender;

    [Required] public string role;
}