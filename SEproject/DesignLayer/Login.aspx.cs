using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
         
    }

    protected void loginClicked(object sender, EventArgs e)
    {

        string userName = username.Value;
        string passWord = password.Value;

        Session["userName"] = userName;
        //Server.Transfer("Student/studentHome.aspx");
        Server.Transfer("Admin/adminHome.aspx");


        /*
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-LQH1JMA\\SQLEXPRESS;Initial Catalog=OneStop;Integrated Security=True;Encrypt=False;");
                conn.Open();

                Session["username"] = userName;
                string loginQuery = "select * from users where ID = @username AND password = @password";
                string roleQuery = "select role from users where ID = @username";
                string role = "";

                SqlCommand roleCommand = new SqlCommand(roleQuery, conn); ;
                roleCommand.Parameters.AddWithValue("@username", userName);
                role = roleCommand.ExecuteScalar().ToString();
                roleCommand.Dispose();

                SqlCommand loginCommand;
                loginCommand = new SqlCommand(loginQuery, conn);
                loginCommand.Parameters.AddWithValue("@username", userName);
                loginCommand.Parameters.AddWithValue("@password", passWord);
                SqlDataReader res1 = loginCommand.ExecuteReader();
                if (!res1.HasRows)
                {
                    //MessageBox.Show("          USERNAME OR PASSWORD DON'T MATCH          ");
                }

                else
                {
                    Session["userName"] = userName;

                    if (role == "student")
                        Server.Transfer("studentHome.aspx");
                     else if (role == "faculty")
                         Server.Transfer("FHome.aspx");
                     else if (role == "admin")
                         Server.Transfer("AHome.aspx");

                    loginCommand.Dispose();
                    res1.Close();

                }*/

    }
}