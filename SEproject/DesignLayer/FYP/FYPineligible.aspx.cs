using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DesignLayer_FYP_FYPineligible : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        string connectionString = "Data Source=DESKTOP-LQH1JMA\\SQLEXPRESS;Initial Catalog=OneStop;Integrated Security=True;Encrypt=False;";

        string query = "SELECT ID, NAME, BATCH,FYPapproval FROM degreeRequests where tokenID is not NULL AND FYPapproval != 'approved'";

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
                string fyp = reader["FYPapproval"].ToString();
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

                TableCell cellFyp = new TableCell();
                cellFyp.Text = fyp;
                row.Cells.Add(cellFyp);


                //creating button for each row
                Button disapproveButton = new Button();
                disapproveButton.Text = "Disapprove";
                disapproveButton.ID = "disapproveButton_" + id;
                disapproveButton.CommandArgument = id; // Store data in CommandArgument
                disapproveButton.Click += new EventHandler(disapprove); // Assign event handler
                disapproveButton.Attributes.Add("runat", "server"); // Add runat="server" attribute
                TableCell cellButton = new TableCell();
                cellButton.Controls.Add(disapproveButton);
                row.Cells.Add(cellButton);

                // Add the row to the table
                dataTable.Rows.Add(row);
            }

            reader.Close();
        }
    }

    protected void disapprove(object sender, EventArgs e)
    {
        Button btn = (Button)sender;

        string[] args = btn.CommandArgument.Split('|');
        string id = args[0];

        DateTime currentTime = DateTime.Now;
        DateTime currentDate = DateTime.Today;
        string formattedTime = currentTime.ToString("HH:mm:ss");
        string formattedDate = currentDate.ToString("yyyy-MM-dd");


        DegreeForm form = new DegreeForm();
        form.SetFYPApproval("not approved");
        form.SetFYPTime(formattedTime);
        form.SetFYPDate(formattedDate);
        form.SetID(id);

        DatabaseFactory.getInstance().GenerateIneligibleforFYP(form);
    }
}