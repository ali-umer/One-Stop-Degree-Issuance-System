using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void loginClicked(object sender, EventArgs e)
    {

        string userName = username.Value;
        string passWord = password.Value;

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
            Response.Write("<script>alert('WRONG CREDENTIALS')</script>");

        }

        else
        {
            Session["userName"] = userName;

            if (role == "Student")
                Server.Transfer("/DesignLayer/Student/studentHome.aspx");

            else if (role == "Admin")
                Server.Transfer("/DesignLayer/Admin/adminHome.aspx");

            else if (role == "Director")
                Server.Transfer("/DesignLayer/Director/directorHome.aspx");

            else if (role == "FYP")
                Server.Transfer("/DesignLayer/FYP/FYPhome.aspx");


            else if (role == "Finance")
                Server.Transfer("/DesignLayer/Finance/financeHome.aspx");

            loginCommand.Dispose();
            res1.Close();

        }

    }
}