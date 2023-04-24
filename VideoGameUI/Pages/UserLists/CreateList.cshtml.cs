using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using System.ComponentModel;
using VideoGameUI.Models;
using VideoGameUI.UI.Models;

namespace VideoGameUI.Pages.UserLists
{
    public class CreateListModel : PageModel
    {
        public List<SelectListItem> VideoGameList { get; set; } = new List<SelectListItem>();
        [BindProperty]
        public Lists NewLists { get; set; } = new Lists();

        public void OnGet()
        {
            PopulateVideoGameList();
        }
        private void PopulateVideoGameList()
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnectionString()))
            {
                string sqlVideoGame = "SELECT VideoGameID, GameTitle FROM VideoGame Order By GameTitle";
                SqlCommand cmd = new SqlCommand(sqlVideoGame, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var VideoGame = new SelectListItem();
                        VideoGame.Value = reader["VideoGameID"].ToString();
                        VideoGame.Text = reader["GameTitle"].ToString();
                        VideoGameList.Add(VideoGame);
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
                    string sql = "INSERT INTO UserList(ListName, Username, ListSize, VideoGameID, Created )"
                        + "VALUES (@listName, @listSize, @userName, @videoGameID, @created)";
                    string sqlVideoGameID = "SELECT @@Identity";
                    // step 3
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ListName", NewLists.ListName);
                    cmd.Parameters.AddWithValue("@UserName", NewLists.Username);
                    cmd.Parameters.AddWithValue("@ListSize", NewLists.ListSize = 5);
                    cmd.Parameters.AddWithValue("@VideoGameID", NewLists.VideoGameID);
                    cmd.Parameters.AddWithValue("@Created", NewLists.Created = DateTime.Now);
                    // cmd.Parameters.AddWithValue("@esrbImageURL", NewESRB.ESRBImageURL);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = sqlVideoGameID;
                    return Page();
                }
            }
            else
            {
                return Page();
            }
        }
    }
}
