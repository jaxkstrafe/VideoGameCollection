using System.ComponentModel.DataAnnotations;

namespace VideoGameUI.Models
{
    public class Publisher
    {

        [Key]
        public int PublisherID { get; set; }
        public string? PublisherName { get; set; }
        public string? PublisherAddress1 { get; set; }
        public string? PublisherAddress2 { get; set; }
        public string? PublisherCity { get; set; }
        public string? PublisherState { get; set; }
        public string? PublisherZip { get; set; }
        public string? PublisherCountry { get; set; }
        public string? PublisherWebsite { get; set; }
        public string? PublisherPhone { get; set; }
        public string? PublisherLogoURL { get; set; }
    }
}
