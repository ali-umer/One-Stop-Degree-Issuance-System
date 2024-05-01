using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DesignLayer_Student_studentFeedbackForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitClicked(object sender, EventArgs e)
    {
        FeedbackForm form = new FeedbackForm();
        form.setID(Session["userName"].ToString());
        form.setFeedback(feedback.Value);

        DatabaseFactory.getInstance().insertFeedback(form);
    }
}