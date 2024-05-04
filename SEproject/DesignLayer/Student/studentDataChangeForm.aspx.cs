using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DesignLayer_Student_studentDataChangeForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void submitClicked(object sender, EventArgs e)
    {

        DataChangeForm form = new DataChangeForm();
        form.setID(Session["userName"].ToString());
        form.setRequestOption(category.SelectedValue);
        form.setRequestValue(value.Value);

        DatabaseFactory.getInstance().insertDataChangeRequest(form);
    }
}