using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class OneStopAdmin : User
{
    private string adminID;

    public OneStopAdmin()
    {
        this.adminID = null;
    }

    public void setAdminID(string adminID)
    {
        this.adminID = adminID;
    }

    public string getAdminID()
    {
        return this.adminID;
    }
}