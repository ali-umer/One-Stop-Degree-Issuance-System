using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DesignLayer_Director_directorDepartmentStats : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connectionString = "Data Source=DESKTOP-LQH1JMA\\SQLEXPRESS;Initial Catalog=OneStop;Integrated Security=True;Encrypt=False;";

        string queryforFYP = "SELECT ROUND(AVG((DATEDIFF(SECOND, TokenDate + CAST(TokenTime AS datetime), FYPDate + CAST(FYPTime AS datetime))) / 60.0), 4) AS AverageTimeInMinutes FROM degreeRequests;";
        string queryforFinance = "SELECT ROUND(AVG((DATEDIFF(SECOND, TokenDate + CAST(TokenTime AS datetime), financeDate + CAST(financeTime AS datetime))) / 60.0), 4) AS AverageTimeInMinutes FROM degreeRequests;";


        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            SqlCommand commandforFYP = new SqlCommand(queryforFYP, connection);

            object result = commandforFYP.ExecuteScalar();
            string average = result != null ? result.ToString() : "N/A";
            fyp.InnerHtml = "<strong> Average time taken by  FYP department: </strong>" + average + " minutes";

            SqlCommand commandforFinance = new SqlCommand(queryforFinance, connection);

            result = commandforFinance.ExecuteScalar();
            average = result != null ? result.ToString() : "N/A";
            finance.InnerHtml = "<strong> Average time taken by Finance department: </strong>" + average + " minutes";



        }
    }
}