using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Web;

public class FeedbackForm
{
    private string ID;
    private string feedback;
    public FeedbackForm()
    {
        this.ID = null;
        this.feedback = null;
    }

    public void setID(string ID)
    {
        this.ID = ID;
    }

    public string getID()
    {
        return this.ID;
    }
    public void setFeedback(string feedback)
    {
        this.feedback = feedback;
    }
    public string getFeedback() 
    {
        return this.feedback;
    }

}