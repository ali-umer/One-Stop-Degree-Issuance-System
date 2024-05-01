using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Xml.Linq;

public class Student : User
{
    private string studentID;
    private string fatherName;
    private string batch;

    public Student()
    {
        this.studentID = null;
        this.fatherName = null;
        this.batch = null;
    }

    public void setID(string ID)
    {
        this.studentID = ID;
    }

    public string getID()
    {
        return this.studentID;
    }

    public void setFatherName(string FatherName)
    {
        this.fatherName = FatherName;
    }

    public string getFatherName()
    {
        return this.fatherName;
    }

    public void setBatch(string batch)
    {
        this.batch = batch;
    }

    public string getBatch()
    {
        return this.batch;
    }
}