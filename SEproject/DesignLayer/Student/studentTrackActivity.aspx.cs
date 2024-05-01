using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DesignLayer_Student_studentTrackActivity : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connectionString = "Data Source=DESKTOP-LQH1JMA\\SQLEXPRESS;Initial Catalog=OneStop;Integrated Security=True;Encrypt=False;";

        string query = "SELECT NAME,FINANCEAPPROVAL,FYPAPPROVAL,FINALSTATUS,OUTSTANDINGDUES,DEGREEFEE FROM DEGREEREQUESTS where ID = @username";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("username", Session["username"].ToString());
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string name = reader["NAME"].ToString();
                string fyp = reader["FYPAPPROVAL"].ToString();
                string finance = reader["FINANCEAPPROVAL"].ToString();
                string outStanding = reader["OUTSTANDINGDUES"].ToString();
                string fee = reader["DEGREEFEE"].ToString();
                string final = reader["FINALSTATUS"].ToString();


                // Creating a new table row
                TableRow row = new TableRow();

                // Creating table cells and adding them to the row
                TableCell cellName = new TableCell();
                cellName.Text = name;
                row.Cells.Add(cellName);

                TableCell cellFYP = new TableCell();
                cellFYP.Text = fyp;
                row.Cells.Add(cellFYP);

                TableCell cellfinance = new TableCell();
                cellfinance.Text = finance;
                row.Cells.Add(cellfinance);

                TableCell cellOut = new TableCell();
                cellOut.Text = outStanding;
                row.Cells.Add(cellOut);
                
                TableCell cellFee = new TableCell();
                cellFee.Text = fee;
                row.Cells.Add(cellFee); 
                
                
                TableCell cellfinal = new TableCell();
                cellfinal.Text = final;
                row.Cells.Add(cellfinal);

                // Add the row to the table
                dataTable.Rows.Add(row);
            }

            reader.Close();
        }
    }
}