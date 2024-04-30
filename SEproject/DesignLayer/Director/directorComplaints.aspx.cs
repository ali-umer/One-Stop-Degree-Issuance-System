using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DesignLayer_Director_directorComplaints : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connectionString = "Data Source=DESKTOP-LQH1JMA\\SQLEXPRESS;Initial Catalog=OneStop;Integrated Security=True;Encrypt=False;";

        string query = "SELECT ID, DEPARTMENT, COMPLAINT FROM COMPLAINTS";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string id = reader["ID"].ToString();
                string complaint = reader["COMPLAINT"].ToString();
                string department = reader["DEPARTMENT"].ToString();

                // Creating a new table row
                TableRow row = new TableRow();

                // Creating table cells and adding them to the row
                TableCell cellId = new TableCell();
                cellId.Text = id;
                row.Cells.Add(cellId);

                TableCell cellDepartment = new TableCell();
                cellDepartment.Text = department;
                row.Cells.Add(cellDepartment);


                TableCell cellComplaint = new TableCell();
                cellComplaint.Text = complaint;
                row.Cells.Add(cellComplaint);

                // Add the row to the table
                dataTable.Rows.Add(row);
            }

            reader.Close();
        }
    }
}