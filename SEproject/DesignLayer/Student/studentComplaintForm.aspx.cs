using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel.Security;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

public partial class DesignLayer_Student_studentComplaintForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitClicked(object sender, EventArgs e)
    {
        ComplaintForm complaintForm = new ComplaintForm();

        complaintForm.setID(Session["userName"].ToString());
        complaintForm.setDepartment(department.SelectedValue);
        complaintForm.setComplaint(complaint.Value);
        complaintForm.setStatus("Not Solved");

        DatabaseFactory.getInstance().insertComplaint(complaintForm);
    }
}