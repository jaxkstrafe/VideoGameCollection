using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using VideoGameUI.Models;
using VideoGameUI.UI.Models;

namespace VideoGameUI.Pages.AddItems
{
    public class AddGenreModel : PageModel
    {
        [BindProperty]
        public Genre NewGenre { get; set; } = new Genre();

        public void OnGet()
        {
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
                    string sql = "INSERT INTO Genre(GenreName) " + "VALUES (@genreName)";
                    // step 3
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@genreName", NewGenre.GenreName);
                    conn.Open();
                    cmd.ExecuteNonQuery();
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
