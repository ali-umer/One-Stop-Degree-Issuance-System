using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DesignLayer_FYP_FYPrequestStats : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connectionString = "Data Source=DESKTOP-LQH1JMA\\SQLEXPRESS;Initial Catalog=OneStop;Integrated Security=True;Encrypt=False;";

        string query = "SELECT ROUND(AVG((DATEDIFF(SECOND, TokenDate + CAST(TokenTime AS datetime), FYPDate + CAST(FYPTime AS datetime))) / 60.0), 4) AS AverageTimeInMinutes FROM degreeRequests;";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);

            object result = command.ExecuteScalar();
            string average = result != null ? result.ToString() : "N/A";
            stat.InnerHtml = "<strong> Average time taken: </strong>" + average + " minutes";
        }
    }
}