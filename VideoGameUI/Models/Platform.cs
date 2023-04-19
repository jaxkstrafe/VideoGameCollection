using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace VideoGameUI.Models
{

    [BindProperties]
    public class Platform
    {

        [Key]
        public int PlatformID { get; set; }
        public string? PlatformName { get; set; }
    }
}
