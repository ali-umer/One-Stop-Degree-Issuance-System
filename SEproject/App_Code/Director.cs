using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Director : User
{
    public string directorID;
    public Director()
    {
        this.directorID = null;
    }

    public void setDirectorID(string directorID)
    {
        this.directorID = directorID;
    }
    public string getDirectorID() 
    {
        return this.directorID;
    }

}