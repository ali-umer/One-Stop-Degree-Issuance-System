using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DesignLayer_Finance_financeRequestLog : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        string connectionString = "Data Source=DESKTOP-LQH1JMA\\SQLEXPRESS;Initial Catalog=OneStop;Integrated Security=True;Encrypt=False;";

        string query = "SELECT ID, NAME, BATCH,OUTSTANDINGDUES,DEGREEFEE,FINANCEAPPROVAL FROM degreeRequests where tokenID is not NULL";

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
                string finance = reader["FINANCEAPPROVAL"].ToString();
                string outstandingDues = reader["OUTSTANDINGDUES"].ToString();
                string degreeFee = reader["DEGREEFEE"].ToString();

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

                TableCell cellOut = new TableCell();
                cellOut.Text = outstandingDues;
                row.Cells.Add(cellOut);

                TableCell cellfee = new TableCell();
                cellfee.Text = degreeFee;
                row.Cells.Add(cellfee);


                TableCell cellFinance = new TableCell();
                cellFinance.Text = finance;
                row.Cells.Add(cellFinance);


                //creating button for each row
                Button approveButton = new Button();
                approveButton.Text = "Approve";
                approveButton.ID = "approveButton_" + id;
                approveButton.CommandArgument = id; // Store data in CommandArgument
                approveButton.Click += new EventHandler(approve); // Assign event handler
                approveButton.Attributes.Add("runat", "server"); // Add runat="server" attribute
                TableCell cellButton = new TableCell();
                cellButton.Controls.Add(approveButton);
                row.Cells.Add(cellButton);

                // Add the row to the table
                dataTable.Rows.Add(row);
            }

            reader.Close();
        }
    }

    protected void approve(object sender, EventArgs e)
    {
        Button btn = (Button)sender;

        string[] args = btn.CommandArgument.Split('|');
        string id = args[0];
        string dues = null, fee = null;
        string connectionString = "Data Source=DESKTOP-LQH1JMA\\SQLEXPRESS;Initial Catalog=OneStop;Integrated Security=True;Encrypt=False;";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            DateTime currentTime = DateTime.Now;
            DateTime currentDate = DateTime.Today;
            string formattedTime = currentTime.ToString("HH:mm:ss");
            string formattedDate = currentDate.ToString("yyyy-MM-dd");

            string checkQuery = "SELECT OUTSTANDINGDUES, DEGREEFEE FROM DEGREEREQUESTS WHERE ID = @id";
          
            SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
            checkCommand.Parameters.AddWithValue("id", id);
            SqlDataReader reader = checkCommand.ExecuteReader();

            while (reader.Read())
            {
                dues = reader["OUTSTANDINGDUES"].ToString();
                fee = reader["DEGREEFEE"].ToString();

            }
            reader.Close();

            if (dues == "none" && fee == "paid")
            {
                string updateQuery = "Update degreeRequests set Financeapproval = 'approved', financeTime = @FinanceTime,financeDate = @financeDate where ID = @id";

                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                updateCommand.Parameters.AddWithValue("FinanceTime", formattedTime);
                updateCommand.Parameters.AddWithValue("financeDate", formattedDate);
                updateCommand.Parameters.AddWithValue("id", id);
                updateCommand.ExecuteNonQuery();
            }
        }
    }
}