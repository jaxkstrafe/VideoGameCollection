using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using VideoGameUI.Models;
using VideoGameUI.UI.Models;

namespace VideoGameUI.Pages.AddItems
{
    public class AddGameModel : PageModel
    {
        [BindProperty]
        public VideoGame NewVideoGame { get; set; } = new VideoGame();
        [BindProperty]
        public List<SelectListItem> GenreList { get; set; } = new List<SelectListItem>();
        [BindProperty]
        public List<SelectListItem> ESRBRating { get; set; } = new List<SelectListItem>();
        [BindProperty]
        public List<SelectListItem> DeveloperList { get; set; } = new List<SelectListItem>();
        [BindProperty]
        public List<SelectListItem> PublisherList { get; set; } = new List<SelectListItem>();
        [BindProperty]
        public List<SelectListItem> PlatFormList { get; set; } = new List<SelectListItem>();
        [BindProperty]
        public List<int> GenresSelected { get; set; }
        public void OnGet()
        {
            PopulateGenreList();
            PopulateEsrbList();
            PopulateDeveloperList();
            PopulatePublisherList();
            PopulatePlatformList();
        }

        private void PopulateEsrbList()
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnectionString()))
            {
                string sqlESRB = "SELECT ESRBID, ESRBImageURL FROM ESRB Order By ESRBID";
                SqlCommand cmd = new SqlCommand(sqlESRB, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var ESRB = new SelectListItem();
                        ESRB.Value = reader["ESRBID"].ToString();
                        ESRB.Text = reader["ESRBImageURL"].ToString();
                        ESRBRating.Add(ESRB);
                    }
                }
            }
        }

        private void PopulatePlatformList()
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnectionString()))
            {
                string sqlPlatform = "SELECT PlatformID, PlatformName FROM Platform Order By PlatformID";
                SqlCommand cmd = new SqlCommand(sqlPlatform, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var Platform = new SelectListItem();
                        Platform.Value = reader["PlatformID"].ToString();
                        Platform.Text = reader["PlatformName"].ToString();
                        PlatFormList.Add(Platform);
                    }
                }
            }
        }

        private void PopulateGenreList()
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnectionString()))
            {
                string sqlGenre = "SELECT GenreId, GenreName FROM Genre Order By GenreName";
                SqlCommand cmd = new SqlCommand(sqlGenre, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var genre = new SelectListItem();
                        genre.Value = reader["GenreId"].ToString();
                        genre.Text = reader["GenreName"].ToString();
                        GenreList.Add(genre);
                    }
                }
            }
        }

        private void PopulateDeveloperList()
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnectionString()))
            {
                string sqlDeveloper = "SELECT DeveloperID, DevName FROM Developer Order By DevName";
                SqlCommand cmd = new SqlCommand(sqlDeveloper, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var developer = new SelectListItem();
                        developer.Value = reader["DeveloperId"].ToString();
                        developer.Text = reader["DevName"].ToString();
                        DeveloperList.Add(developer);
                    }
                }
            }
        }

        private void PopulatePublisherList()
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnectionString()))
            {
                string sqlPublisher = "SELECT PublisherID, PublisherName FROM Publisher Order By PublisherName";
                SqlCommand cmd = new SqlCommand(sqlPublisher, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var publisher = new SelectListItem();
                        publisher.Value = reader["PublisherId"].ToString();
                        publisher.Text = reader["PublisherName"].ToString();
                        PublisherList.Add(publisher);
                    }
                }
            }
        }


        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                /*
                             * 1. Create a SQL connection object
                             * 2. Construct a SQL statement
                             * 3. Create a SQL command object
                             * 4. Open the SQL connection
                             * 5. Execute the SQL command
                             * 6. Close the SQL connection
                             * 
                             */
                using (SqlConnection conn = new SqlConnection(DBHelper.GetConnectionString()))
                {
                    // step 1
                    // step 2
                    string sql = "INSERT INTO VideoGame(GameTitle, ReleaseDate, Price, ESRBID, CriticAverage, UserAverage, GameImageURL) " + 
                        "VALUES (@gameTitle, @releaseDate, @price, @esrbID, @criticAverage, @userAverage, @gameImageURL)";
                    string sqlESRBID = "SELECT @@Identity";
                    string sqlPlatformID = "SELECT @@Identity";
                    string sqlDeveloperID = "SELECT @@Identity";
                    string sqlPublisherID = "SELECT @@Identity";
                    // step 3
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@gameTitle", NewVideoGame.GameTitle);
                    cmd.Parameters.AddWithValue("@releaseDate", NewVideoGame.RelaseDate);
                    cmd.Parameters.AddWithValue("@price", NewVideoGame.Price);
                    cmd.Parameters.AddWithValue("@esrbID", NewVideoGame.ESRBID);
                    cmd.Parameters.AddWithValue("@criticAverage", NewVideoGame.CriticAverage);
                    cmd.Parameters.AddWithValue("@userAverage", NewVideoGame.UserAverage);
                    cmd.Parameters.AddWithValue("@gameImageURL", NewVideoGame.GameImageURL);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = sqlESRBID;
                    cmd.CommandText = sqlDeveloperID;
                    cmd.CommandText = sqlPublisherID;
                    cmd.CommandText = sqlPlatformID;
                    int VideoGameID = int.Parse(cmd.ExecuteScalar().ToString());

                    string sqlGameGenre = "INSERT INTO GameGenre(VideoGameId, GenreId) VALUES (@VideoGameId, @genreId)";
                    cmd.CommandText = sqlGameGenre;

                    for (int i = 0; i < GenresSelected.Count(); i++)
                    {
                        cmd.Parameters.AddWithValue("@videoGameId", VideoGameID);
                        cmd.Parameters.AddWithValue("@genreId", GenresSelected[i]);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    return RedirectToPage("Pages/Index");
                }
            }
            else
            {
                return Page();
            }
        }
    }
}
