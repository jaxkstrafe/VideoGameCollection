using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace VideoGameUI.Models
{
    [BindProperties]

    public class Genre
    {

        [Key]
        public int GenreId { get; set; }
        public string? GenreName { get; set; }
    }
}
