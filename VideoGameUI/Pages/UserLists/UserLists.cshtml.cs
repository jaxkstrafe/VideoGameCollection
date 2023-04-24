using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using VideoGameUI.Models;
using VideoGameUI.UI.Models;

namespace VideoGameUI.Pages.UserLists
{
    public class IndexModel : PageModel
    {
        public List<VideoGame> VideoGames { get; set; } = new List<VideoGame>();

        public List<Lists> UserLists { get; set; } = new List<Lists>();
        public void OnGet()
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnectionString()))
            {
                string sql = "SELECT * FROM UserList Order By Created desc";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Lists UserList = new Lists();
                        UserList.ListID = int.Parse(reader["ListID"].ToString());
                        UserList.Username = reader["UserName"].ToString();
                        UserList.ListName = reader["ListName"].ToString();
                        UserList.VideoGameID = int.Parse(reader["ListID"].ToString());
                        UserList.Created = DateTime.Parse(reader["Created"].ToString());
                        UserLists.Add(UserList);
                    }
                }
            }
        }

        public void onPost()
        {

        }
    }
}
