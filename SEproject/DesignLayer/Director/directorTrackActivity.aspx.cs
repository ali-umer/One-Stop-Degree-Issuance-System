using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DesignLayer_Director_directorTrackActivity : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        string connectionString = "Data Source=DESKTOP-LQH1JMA\\SQLEXPRESS;Initial Catalog=OneStop;Integrated Security=True;Encrypt=False;";

        string query = "SELECT ID, NAME,tokenID,tokenTime,financeApproval,financeTime,FYPapproval,FYPtime,finalStatus,tokenDate,FYPdate,financeDate FROM degreeRequests";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string id = reader["ID"].ToString();
                string name = reader["NAME"].ToString();
                string token = reader["tokenID"].ToString();
                string tokenTime = reader["tokenTime"].ToString();
                string finance = reader["financeApproval"].ToString();
                string financeTime = reader["financeTime"].ToString();
                string fyp = reader["FYPapproval"].ToString();
                string fypTime = reader["FYPtime"].ToString();
                string final = reader["finalStatus"].ToString();
                string tokenDate = reader["tokenDate"].ToString();
                string FYPdate = reader["FYPdate"].ToString();
                string financeDate = reader["financeDate"].ToString();

                // Creating a new table row
                TableRow row = new TableRow();

                // Creating table cells and adding them to the row
                TableCell cellId = new TableCell();
                cellId.Text = id;
                row.Cells.Add(cellId);

                TableCell cellName = new TableCell();
                cellName.Text = name;
                row.Cells.Add(cellName);

                TableCell cellToken = new TableCell();
                cellToken.Text = token;
                row.Cells.Add(cellToken);

                TableCell cellTokentime = new TableCell();
                cellTokentime.Text = tokenTime;
                row.Cells.Add(cellTokentime);

                TableCell cellTokenDate = new TableCell();
                cellTokenDate.Text = tokenDate;
                row.Cells.Add(cellTokenDate);

                TableCell cellFinance = new TableCell();
                cellFinance.Text = finance;
                row.Cells.Add(cellFinance);

                TableCell cellFinanceTime = new TableCell();
                cellFinanceTime.Text = financeTime;
                row.Cells.Add(cellFinanceTime);

                TableCell cellFinanceDate = new TableCell();
                cellFinanceDate.Text = financeDate;
                row.Cells.Add(cellFinanceDate);

                TableCell cellFyp = new TableCell();
                cellFyp.Text = fyp;
                row.Cells.Add(cellFyp);

                TableCell cellFypTime = new TableCell();
                cellFypTime.Text = fypTime;
                row.Cells.Add(cellFypTime);

                TableCell cellFypDate = new TableCell();
                cellFypDate.Text = FYPdate;
                row.Cells.Add(cellFypDate);

                TableCell cellFinal = new TableCell();
                cellFinal.Text = final;
                row.Cells.Add(cellFinal);

                // Add the row to the table
                dataTable.Rows.Add(row);
            }

            reader.Close();
        }
    }
}