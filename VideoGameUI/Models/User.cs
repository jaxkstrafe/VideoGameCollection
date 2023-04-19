using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace VideoGameUI.Models
{
    [BindProperties]

    public class User
    {

        [Key]
        public int UserName { get; set; }
        public string? Email { get; set; }
        public string? UserDescription { get; set; }
        public string? AvatarURL { get; set; }
        public string? salt { get; set; }
        public string? PasswordHash { get; set; }
        

    }
}
