using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace VideoGameUI.Models
{
    [BindProperties]
    public class VideoGame
    {

        [Key]
        public int VideoGameID { get; set; }
        public string? GameTitle { get; set; }
        public DateTime RelaseDate { get; set;}
        public decimal Price { get; set; }
        public int ESRBID { get; set; }
        public decimal CriticAverage { get; set; }
        public decimal UserAverage { get; set; }
        public string? GameImageURL { get; set; }

    }
}
