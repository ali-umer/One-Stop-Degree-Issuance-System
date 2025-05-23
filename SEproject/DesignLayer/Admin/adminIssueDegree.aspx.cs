﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DesignLayer_Admin_adminIssueDegree : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connectionString = "Data Source=DESKTOP-LQH1JMA\\SQLEXPRESS;Initial Catalog=OneStop;Integrated Security=True;Encrypt=False;";

        string query = "SELECT ID, NAME, BATCH, FYPapproval, financeApproval,FinalStatus FROM degreeRequests where tokenID is not NULL";

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
                string finance = reader["financeApproval"].ToString();
                string final = reader["finalStatus"].ToString();

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

                TableCell cellFinance = new TableCell();
                cellFinance.Text = finance;
                row.Cells.Add(cellFinance);

                TableCell cellFinal = new TableCell();
                cellFinal.Text = final;
                row.Cells.Add(cellFinal);

                //creating button for each row
                Button generateButton = new Button();
                generateButton.Text = "Generate";
                generateButton.ID = "generateButton_" + id;
                generateButton.CommandArgument = id; // Store data in CommandArgument
                generateButton.Click += new EventHandler(generateButton_Click); // Assign event handler
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

    protected void generateButton_Click(object sender, EventArgs e)
    {
        Button btn = (Button)sender;

        string[] args = btn.CommandArgument.Split('|');
        string id = args[0];
        DegreeForm degreeForm = new DegreeForm();
        degreeForm.SetID(id);

        DatabaseFactory.getInstance().setFinalStatus(degreeForm);

    }
}