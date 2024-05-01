using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DesignLayer_Student_studentHome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Student student = DatabaseFactory.getInstance().getPersonalDetailsofStudent(Session["userName"].ToString());

        name.InnerHtml = "<strong>NAME: </strong>" + student.getName();
        DOB.InnerHtml = "<strong>DOB: </strong>" + student.getDOB();
        fatherName.InnerHtml = "<strong>FATHER NAME: </strong>" + student.getFatherName();
        batch.InnerHtml = "<strong>BATCH: </strong>" + student.getBatch();
        CNIC.InnerHtml = "<strong>CNIC: </strong>" + student.getCNIC();
        nationality.InnerHtml = "<strong>NATIONALITY: </strong>" + student.getNationality();
        contact.InnerHtml = "<strong>CONTACT: </strong>" + student.getContact();
        campus.InnerHtml = "<strong>CAMPUS: </strong>" + student.getCampus();
    }

}