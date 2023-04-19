using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using VideoGameUI.Models;
using VideoGameUI.UI.Models;

namespace VideoGameUI.Pages.GamesCollection
{
    public class IndexModel : PageModel
    {
        public List<VideoGame> VideoGames { get; set; } = new List<VideoGame>();
        public void OnGet()
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnectionString()))
            {
                string sql = "SELECT * FROM VideoGame Order By GameTitle";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        VideoGame videogames = new VideoGame();
                        videogames.VideoGameID = int.Parse(reader["VideoGameID"].ToString());
                        videogames.GameTitle = reader["GameTitle"].ToString();
                        videogames.Price = decimal.Parse(reader["Price"].ToString());
                        videogames.RelaseDate = DateTime.Parse(reader["ReleaseDate"].ToString());
                        videogames.CriticAverage = decimal.Parse(reader["CriticAverage"].ToString());
                        videogames.UserAverage = decimal.Parse(reader["UserAverage"].ToString());
                        videogames.GameImageURL = reader["GameImageURL"].ToString();
                        VideoGames.Add(videogames);
                    }
                }
            }
        }
    }
}
