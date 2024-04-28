using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DesignLayer_Student_studentFeedbackForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitClicked(object sender, EventArgs e)
    {
        string userName = Session["userName"].ToString();

        string connectionString = "Data Source=DESKTOP-LQH1JMA\\SQLEXPRESS;Initial Catalog=OneStop;Integrated Security=True;Encrypt=False;";


        string checkQuery = "select finalStatus from degreeRequests where ID = @userName";
        string finalStatus = null;

        string insertQuery = "INSERT INTO feedback VALUES (@userName,@feedback)";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
            checkCommand.Parameters.AddWithValue("@userName", userName);

            object result = checkCommand.ExecuteScalar();

            if (result != null)
            {
                finalStatus = result.ToString();
            }
            if (finalStatus == "generated")
            {
                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                insertCommand.Parameters.AddWithValue("@userName", userName);
                insertCommand.Parameters.AddWithValue("@feedback", feedback.Value);
                insertCommand.ExecuteNonQuery();
            }

        }
    }
}