using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DesignLayer_Admin_adminUpdateStudentData : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connectionString = "Data Source=DESKTOP-LQH1JMA\\SQLEXPRESS;Initial Catalog=OneStop;Integrated Security=True;Encrypt=False;";

        string query = "SELECT ID, REQUESTOPTION, REQUESTVALUE FROM dataChangeRequest";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string id = reader["ID"].ToString();
                string requestOption = reader["REQUESTOPTION"].ToString();
                string requestValue = reader["REQUESTVALUE"].ToString();

                // Creating a new table row
                TableRow row = new TableRow();

                // Creating table cells and adding them to the row
                TableCell cellId = new TableCell();
                cellId.Text = id;
                row.Cells.Add(cellId);

                TableCell cellOption = new TableCell();
                cellOption.Text = requestOption;
                row.Cells.Add(cellOption);

                TableCell cellValue = new TableCell();
                cellValue.Text = requestValue;
                row.Cells.Add(cellValue);

                //creating button for each row
                Button acceptButton = new Button();
                acceptButton.Text = "Accept";
                acceptButton.ID = "acceptButton_" + id + requestOption; // Set a unique ID for each button
                acceptButton.CommandArgument = id + "|" + requestOption + "|" + requestValue; // Store data in CommandArgument
                acceptButton.Click += new EventHandler(AcceptButton_Click); // Assign event handler
                acceptButton.Attributes.Add("runat", "server"); // Add runat="server" attribute
                TableCell cellButton = new TableCell();
                cellButton.Controls.Add(acceptButton);
                row.Cells.Add(cellButton);


                // Add the row to the table
                dataTable.Rows.Add(row);
            }

            reader.Close();
        }
    }

    protected void AcceptButton_Click(object sender, EventArgs e)
    {
        Button btn = (Button)sender;

        string[] args = btn.CommandArgument.Split('|');
        string id = args[0];
        string requestOption = args[1];
        string requestValue = args[2];

        string query = null;

        string connectionString = "Data Source=DESKTOP-LQH1JMA\\SQLEXPRESS;Initial Catalog=OneStop;Integrated Security=True;Encrypt=False;";

        if (requestOption=="name")
        {
            query = "Update users set name = @requestValue where ID = @id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();


                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@requestValue", requestValue);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();

                string deleteQuery = "delete from dataChangeRequest where ID=@id and requestOption = @requestOption";

                SqlCommand deletecommand = new SqlCommand(deleteQuery, connection);
                deletecommand.Parameters.AddWithValue("@id", id);
                deletecommand.Parameters.AddWithValue("@requestOption", requestOption);
                deletecommand.ExecuteNonQuery();

            }
        }
        else
        {
            query = $"UPDATE student SET {requestOption} = @requestValue WHERE studentID = @id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@requestValue", requestValue);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();

                string deleteQuery = "DELETE FROM dataChangeRequest WHERE ID = @id AND requestOption = @requestOption";

                SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                deleteCommand.Parameters.AddWithValue("@id", id);
                deleteCommand.Parameters.AddWithValue("@requestOption", requestOption);
                deleteCommand.ExecuteNonQuery();
            }

        }

       
    }
}