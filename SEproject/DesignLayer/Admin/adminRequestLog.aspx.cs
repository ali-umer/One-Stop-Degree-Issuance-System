using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DesignLayer_Admin_adminRequestLog : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        string connectionString = "Data Source=DESKTOP-LQH1JMA\\SQLEXPRESS;Initial Catalog=OneStop;Integrated Security=True;Encrypt=False;";

        string query = "SELECT ID, NAME, BATCH FROM degreeRequests";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string id = reader["ID"].ToString();
                string name = reader["NAME"].ToString();
                string batch = reader["BATCH"].ToString();

                // Creating a new table row
                TableRow row = new TableRow();

                // Creating table cells and adding them to the row
                TableCell cellId = new TableCell();
                cellId.Text = id;
                row.Cells.Add(cellId);

                TableCell cellName = new TableCell();
                cellName.Text = name;
                row.Cells.Add(cellName);

                TableCell cellBatch = new TableCell();
                cellBatch.Text = batch;
                row.Cells.Add(cellBatch);

                //creating button for each row
                Button generateButton = new Button();
                generateButton.Text = "Generate Token";
                generateButton.ID = "generateButton_" + id;
                generateButton.CommandArgument = id; // Store data in CommandArgument
                generateButton.Click += new EventHandler(generateToken); // Assign event handler
                generateButton.Attributes.Add("runat", "server"); // Add runat="server" attribute
                TableCell cellButton = new TableCell();
                cellButton.Controls.Add(generateButton);
                row.Cells.Add(cellButton);



                // Add the row to the table
                dataTable.Rows.Add(row);
            }

            reader.Close();
        }
    }

    protected void generateToken(object sender, EventArgs e)
    {
        Button btn = (Button)sender;

        string[] args = btn.CommandArgument.Split('|');
        string id = args[0];
        int tokenID;

        string query = "select top 1 tokenID from degreeRequests order by tokenID desc";
      
        string connectionString = "Data Source=DESKTOP-LQH1JMA\\SQLEXPRESS;Initial Catalog=OneStop;Integrated Security=True;Encrypt=False;";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);
            object result = command.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                tokenID = Convert.ToInt32(result.ToString());
            }
            else
            {
                tokenID = 0;
            }
            tokenID++;

            DateTime currentTime = DateTime.Now;
            string formattedTime = currentTime.ToString("HH:mm:ss");

            string updateQuery = "Update degreeRequests set tokenID = @tokenID, tokenTime = @tokenTime,FYPapproval='pending',financeApproval = 'pending' where ID = @id";
            SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
            updateCommand.Parameters.AddWithValue("tokenID", tokenID);
            updateCommand.Parameters.AddWithValue("tokenTime", formattedTime);
            updateCommand.Parameters.AddWithValue("id", id);
            updateCommand.ExecuteNonQuery();


        }
    }
}