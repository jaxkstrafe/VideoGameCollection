using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace VideoGameUI.Models
{
    [BindProperties]
    public class ESRB
    {

        [Key]
        public int ESRBId { get; set; }
        public string? ESRBImageURL { get; set; }
    }
}
