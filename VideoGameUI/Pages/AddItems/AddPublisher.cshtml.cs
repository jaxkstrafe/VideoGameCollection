using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using VideoGameUI.Models;
using VideoGameUI.UI.Models;

namespace VideoGameUI.Pages.AddItems
{
    public class AddPublisherModel : PageModel
    {

        [BindProperty]
        public Publisher NewPublisher { get; set; } = new Publisher();
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
                    string sql = "INSERT INTO Publisher(PublisherName, PublisherAddress1, PublisherAddress2, PublisherCity, PublisherState, " +
                        "PublisherZip, PublisherCountry, PublisherWebsite, PublisherPhone, PublisherLogoURL) "
                        + "VALUES (@publisherName, @publisherAddress1, @publisherAddress2, @publisherCity, @publisherState, @publisherZip, @publisherCountry, @publisherWebsite," +
                        "@publisherPhone, @publisherLogoURL)";
                    // step 3
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@publisherName", NewPublisher.PublisherName);
                    cmd.Parameters.AddWithValue("@publisherAddress1", NewPublisher.PublisherAddress1);
                    cmd.Parameters.AddWithValue("@publisherAddress2", NewPublisher.PublisherAddress2);
                    cmd.Parameters.AddWithValue("@publisherCity", NewPublisher.PublisherCity);
                    cmd.Parameters.AddWithValue("@publisherState", NewPublisher.PublisherState);
                    cmd.Parameters.AddWithValue("@publisherZip", NewPublisher.PublisherZip);
                    cmd.Parameters.AddWithValue("@publisherCountry", NewPublisher.PublisherCountry);
                    cmd.Parameters.AddWithValue("@publisherWebsite", NewPublisher.PublisherWebsite);
                    cmd.Parameters.AddWithValue("@publisherPhone", NewPublisher.PublisherPhone);
                    cmd.Parameters.AddWithValue("@publisherLogoURL", NewPublisher.PublisherLogoURL);
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
