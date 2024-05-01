using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;


public partial class DesignLayer_Student_studentDegreeForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connectionString = "Data Source=DESKTOP-LQH1JMA\\SQLEXPRESS;Initial Catalog=OneStop;Integrated Security=True;Encrypt=False;";

        string userName = Session["userName"].ToString();
        string mainQuery = "SELECT ID,NAME,BATCH FROM student S JOIN users U ON S.studentID= U.ID WHERE S.studentID = @userName";
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
                        name.Value = reader["NAME"].ToString();
                        roll.Value = reader["ID"].ToString();
                        batch.Value = reader["BATCH"].ToString();
                    }
                }
            }
        }
    }


    protected void RequestInitiated(object sender, EventArgs e)
    {

        DegreeForm form = new DegreeForm();
        string batchValue = batch.Value;

        int batchInt;
        if (int.TryParse(batchValue, out batchInt))
        {
            if (batchInt >= 2021)
            {
                form.SetID(roll.Value);
                form.SetName(name.Value);
                form.SetBatch(batch.Value);

                DatabaseFactory.getInstance().InitiateDegreeRequest(form);

            }
            else
            {
                MessageBox.Show("          NOT ELIGIBLE TO APPLY          ");

            }
        }
    }
}