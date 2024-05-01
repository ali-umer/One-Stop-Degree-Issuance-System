using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;


public class ComplaintForm
{
    private string ID;
    private string department;
    private string complaint;
    private string status;
    public ComplaintForm()
    {
        this.ID = null;
        this.department = null;
        this.complaint = null;
        this.status = null;
    }

    public void setID(string ID)
    {
        this.ID = ID;
    }
    public string getID()
    {
        return this.ID;
    }

    public void setDepartment(string department)
    {
        this.department = department;
    }
    public string getDepartment()
    {
        return this.department;
    }

    public void setComplaint(string complaint)
    {
        this.complaint = complaint;
    }

    public string getComplaint()
    {
        return this.complaint;
    }

    public void setStatus(string status)
    {
        this.status = status;
    }

    public string getStatus()
    {
        return this.status;
    }

}