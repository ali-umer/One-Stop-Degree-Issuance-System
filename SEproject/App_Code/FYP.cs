using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class FYP : User
{
    private string departmentID;
    public FYP()
    {
        this.departmentID = null;
    }

    public void setDepartmentID(string departmentID)
    {
        this.departmentID = departmentID;
    }

    public string getDepartmentID()
    {
        return this.departmentID;
    }
}