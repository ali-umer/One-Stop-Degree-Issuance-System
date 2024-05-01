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

        Director director = DatabaseFactory.getInstance().getPersonalDetailsofDirector(Session["userName"].ToString());

        name.InnerHtml = "<strong>NAME: </strong>" + director.getName();
        DOB.InnerHtml = "<strong>DOB: </strong>" + director.getDOB();
        bloodGroup.InnerHtml = "<strong>BLOOD GROUP: </strong>" + director.getBloodGroup();
        gender.InnerHtml = "<strong>GENDER: </strong>" + director.getGender();
        CNIC.InnerHtml = "<strong>CNIC: </strong>" + director.getCNIC();
        nationality.InnerHtml = "<strong>NATIONALITY: </strong>" + director.getNationality();
        contact.InnerHtml = "<strong>CONTACT: </strong>" + director.getContact();
        campus.InnerHtml = "<strong>CAMPUS: </strong>" + director.getCampus();
    }
}