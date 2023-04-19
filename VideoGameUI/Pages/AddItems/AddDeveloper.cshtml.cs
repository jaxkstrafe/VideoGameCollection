using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using VideoGameUI.Models;
using VideoGameUI.UI.Models;

namespace VideoGameUI.Pages.AddItems
{
    public class AddDeveloperModel : PageModel
    {
        [BindProperty]
        public Developer NewDeveloper { get; set; } = new Developer();
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
                    string sql = "INSERT INTO Developer(DevName, DevAddress1, DevAddress2, DevCity, DevState, " +
                        "DevZip, DevCountry, DevWebsite, DevPhone, DevLogoURL) " 
                        + "VALUES (@devName, @devAddress1, @devAddress2, @devCity, @devState, @devZip, @devCountry, @devWebsite, " +
                        "@devPhone, @devLogoURL)";
                    // step 3
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@devName", NewDeveloper.DevName);
                    cmd.Parameters.AddWithValue("@devAddress1", NewDeveloper.DevAddress1);
                    cmd.Parameters.AddWithValue("@devAddress2", NewDeveloper.DevAddress2);
                    cmd.Parameters.AddWithValue("@devCity", NewDeveloper.DevCity);
                    cmd.Parameters.AddWithValue("@devState", NewDeveloper.DevState);
                    cmd.Parameters.AddWithValue("@devZip", NewDeveloper.DevZip);
                    cmd.Parameters.AddWithValue("@devCountry", NewDeveloper.DevCountry);
                    cmd.Parameters.AddWithValue("@devWebsite", NewDeveloper.DevWebsite);
                    cmd.Parameters.AddWithValue("@devPhone", NewDeveloper.DevPhone);
                    cmd.Parameters.AddWithValue("@devLogoURL", NewDeveloper.DevLogoURL);
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
