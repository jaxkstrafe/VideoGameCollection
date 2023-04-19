using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace VideoGameUI.Models
{
    [BindProperties]
    public class Lists
    {
        [Key]
        public int ListID { get; set; }
        public string? Username { get; set; }
        public int ListSize { get; set; }
        public int VideoGameID { get; set; }
        public DateTime Created { get; set; }

    }
}
