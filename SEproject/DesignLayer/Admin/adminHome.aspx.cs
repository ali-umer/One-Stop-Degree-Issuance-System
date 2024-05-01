using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DesignLayer_Admin_adminHome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        OneStopAdmin admin = DatabaseFactory.getInstance().getPersonalDetailsofAdmin(Session["userName"].ToString());

        name.InnerHtml = "<strong>NAME: </strong>" +admin.getName();
        DOB.InnerHtml = "<strong>DOB: </strong>" + admin.getDOB();
        bloodGroup.InnerHtml = "<strong>BLOOD GROUP: </strong>" + admin.getBloodGroup();
        gender.InnerHtml = "<strong>GENDER: </strong>" + admin.getGender();
        CNIC.InnerHtml = "<strong>CNIC: </strong>" + admin.getCNIC();
        nationality.InnerHtml = "<strong>NATIONALITY: </strong>" + admin.getNationality();
        contact.InnerHtml = "<strong>CONTACT: </strong>" + admin.getContact();
        campus.InnerHtml = "<strong>CAMPUS: </strong>" + admin.getCampus();
    }
}