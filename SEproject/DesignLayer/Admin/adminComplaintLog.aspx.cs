using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.DynamicData;

public partial class DesignLayer_Admin_adminComplaintLog : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connectionString = "Data Source=DESKTOP-LQH1JMA\\SQLEXPRESS;Initial Catalog=OneStop;Integrated Security=True;Encrypt=False;";

        string query = "SELECT ID, COMPLAINT,STATUS FROM COMPLAINTS WHERE DEPARTMENT = 'admin'";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string id = reader["ID"].ToString();
                string complaint = reader["COMPLAINT"].ToString();
                string status = reader["STATUS"].ToString();

                // Creating a new table row
                TableRow row = new TableRow();

                // Creating table cells and adding them to the row
                TableCell cellId = new TableCell();
                cellId.Text = id;
                row.Cells.Add(cellId);

                TableCell cellComplaint = new TableCell();
                cellComplaint.Text = complaint;
                row.Cells.Add(cellComplaint);

                TableCell cellStatus = new TableCell();
                cellStatus.Text = status;
                row.Cells.Add(cellStatus);

                //creating button for each row
                Button generateButton = new Button();
                generateButton.Text = "Resolve";
                generateButton.ID = "solveButton_" + id + complaint;
                generateButton.CommandArgument = id + "|" + complaint;
                generateButton.Click += new EventHandler(resolve);
                generateButton.Attributes.Add("runat", "server");
                TableCell cellButton = new TableCell();
                cellButton.Controls.Add(generateButton);
                row.Cells.Add(cellButton);

                // Add the row to the table
                dataTable.Rows.Add(row);
            }

            reader.Close();
        }
    }

    protected void resolve(object sender, EventArgs e)
    {
        Button btn = (Button)sender;

        string[] args = btn.CommandArgument.Split('|');
        string id = args[0];
        string complaint = args[1];
        ComplaintForm form = new ComplaintForm();

        form.setID(id);
        form.setComplaint(complaint);

        DatabaseFactory.getInstance().resolveComplaint(form);

    }
}