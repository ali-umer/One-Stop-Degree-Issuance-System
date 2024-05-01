using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class DataChangeForm
{
    private string ID;
    private string requestOption;
    private string requestValue;
    public DataChangeForm()
    {
        this.ID = null;
        this.requestOption = null;
        this.requestValue = null;
    }

    public void setID(string ID)
    {
        this.ID = ID;
    }

    public string getID()
    {
        return this.ID;
    }

    public void setRequestOption(string requestOption)
    {
        this.requestOption = requestOption;
    }
    public string getRequestOption()
    {
        return this.requestOption;
    }

    public void setRequestValue(string requestValue)
    {
        this.requestValue = requestValue;
    }
    public string getRequestValue()
    {
        return this.requestValue;
    }
}
