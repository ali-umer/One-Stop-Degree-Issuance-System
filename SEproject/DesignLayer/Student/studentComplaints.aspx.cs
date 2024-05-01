using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DesignLayer_Student_studentComplaints : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connectionString = "Data Source=DESKTOP-LQH1JMA\\SQLEXPRESS;Initial Catalog=OneStop;Integrated Security=True;Encrypt=False;";

        string query = "SELECT COMPLAINT,DEPARTMENT, STATUS FROM COMPLAINTS where ID = @username";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("username", Session["username"].ToString());
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string department = reader["DEPARTMENT"].ToString();
                string complaint = reader["COMPLAINT"].ToString();
                string status = reader["STATUS"].ToString();


                // Creating a new table row
                TableRow row = new TableRow();

                // Creating table cells and adding them to the row
                TableCell cellComplaint = new TableCell();
                cellComplaint.Text = complaint;
                row.Cells.Add(cellComplaint);

                TableCell cellDep = new TableCell();
                cellDep.Text = department;
                row.Cells.Add(cellDep);



                TableCell cellStatus = new TableCell();
                cellStatus.Text = status;
                row.Cells.Add(cellStatus);

                // Add the row to the table
                dataTable.Rows.Add(row);
            }

            reader.Close();
        }
    }
}