using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DesignLayer_Student_studentDataChangeForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void submitClicked(object sender, EventArgs e)
    {
 

        string userName = Session["userName"].ToString();

        string connectionString = "Data Source=DESKTOP-LQH1JMA\\SQLEXPRESS;Initial Catalog=OneStop;Integrated Security=True;Encrypt=False;";

        string insertQuery = "INSERT INTO dataChangeRequest VALUES (@userName,@requestOption,@requestValue)";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
            insertCommand.Parameters.AddWithValue("@userName", userName);
            insertCommand.Parameters.AddWithValue("@requestOption", category.SelectedValue) ;
            insertCommand.Parameters.AddWithValue("@requestValue", value.Value);

            insertCommand.ExecuteNonQuery();

        }
    }
}