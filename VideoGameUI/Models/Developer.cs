using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace VideoGameUI.Models
{
    [BindProperties]
    public class Developer
    {

        [Key]
        public int DeveloperID { get; set; }
        public string? DevName { get; set; }
        public string? DevAddress1 { get; set; }
        public string? DevAddress2 { get; set; }
        public string? DevCity { get; set; }
        public string? DevState { get; set; }
        public string? DevZip { get; set; }
        public string? DevCountry { get; set; }
        public string? DevWebsite { get; set; }
        public string? DevPhone { get; set; }
        public string? DevLogoURL { get; set; }
    }

}
