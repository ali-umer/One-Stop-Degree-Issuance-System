using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DesignLayer_Director_directorHome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connectionString = "Data Source=DESKTOP-LQH1JMA\\SQLEXPRESS;Initial Catalog=OneStop;Integrated Security=True;Encrypt=False;";

        string userName = Session["userName"].ToString();
        string mainQuery = "SELECT NAME,DOB,BLOODGROUP,GENDER,CNIC,NATIONALITY,CONTACT,CAMPUS FROM Director D JOIN users U ON D.directorID= U.ID WHERE D.directorID = @userName";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();


            using (SqlCommand command = new SqlCommand(mainQuery, connection))
            {
                command.Parameters.AddWithValue("@userName", userName);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        name.InnerHtml = "<strong>NAME: </strong>" + reader["NAME"].ToString();
                        DOB.InnerHtml = "<strong>DOB: </strong>" + reader["DOB"].ToString();
                        bloodGroup.InnerHtml = "<strong>BLOOD GROUP: </strong>" + reader["BLOODGROUP"].ToString();
                        gender.InnerHtml = "<strong>GENDER: </strong>" + reader["GENDER"].ToString();
                        CNIC.InnerHtml = "<strong>CNIC: </strong>" + reader["CNIC"].ToString();
                        nationality.InnerHtml = "<strong>NATIONALITY: </strong>" + reader["NATIONALITY"].ToString();
                        contact.InnerHtml = "<strong>CONTACT: </strong>" + reader["CONTACT"].ToString();
                        campus.InnerHtml = "<strong>CAMPUS: </strong>" + reader["CAMPUS"].ToString();

                    }
                }
            }
        }
    }
}