using System.ComponentModel.DataAnnotations;

namespace LoginTestAPI.Models.Domain
{
    public class RegisterRequest
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string Roles { get; set; }
    }
}
