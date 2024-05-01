using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DesignLayer_Finance_financeHome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Finance finance = DatabaseFactory.getInstance().getPersonalDetailsofFinance(Session["userName"].ToString());

        name.InnerHtml = "<strong>NAME: </strong>" + finance.getName();
        DOB.InnerHtml = "<strong>DOB: </strong>" + finance.getDOB();
        bloodGroup.InnerHtml = "<strong>BLOOD GROUP: </strong>" + finance.getBloodGroup();
        gender.InnerHtml = "<strong>GENDER: </strong>" + finance.getGender();
        CNIC.InnerHtml = "<strong>CNIC: </strong>" + finance.getCNIC();
        nationality.InnerHtml = "<strong>NATIONALITY: </strong>" + finance.getNationality();
        contact.InnerHtml = "<strong>CONTACT: </strong>" + finance.getContact();
        campus.InnerHtml = "<strong>CAMPUS: </strong>" + finance.getCampus();
    }
}
