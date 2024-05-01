using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DesignLayer_FYP_FYPhome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FYP fyp = DatabaseFactory.getInstance().getPersonalDetailsofFYP(Session["userName"].ToString());

        name.InnerHtml = "<strong>NAME: </strong>" + fyp.getName();
        DOB.InnerHtml = "<strong>DOB: </strong>" + fyp.getDOB();
        bloodGroup.InnerHtml = "<strong>BLOOD GROUP: </strong>" + fyp.getBloodGroup();
        gender.InnerHtml = "<strong>GENDER: </strong>" + fyp.getGender();
        CNIC.InnerHtml = "<strong>CNIC: </strong>" + fyp.getCNIC();
        nationality.InnerHtml = "<strong>NATIONALITY: </strong>" + fyp.getCNIC();
        contact.InnerHtml = "<strong>CONTACT: </strong>" + fyp.getContact();
        campus.InnerHtml = "<strong>CAMPUS: </strong>" + fyp.getContact();
    }
}